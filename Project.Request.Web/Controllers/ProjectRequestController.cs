using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project.Request.Data;
using Project.Request.Models.DataModels;
using Project.Request.Services.Interfaces;
using Project.Request.Web.Models;

namespace Project.Request.Web.Controllers
{
    [Authorize]
    public class ProjectRequestController : Controller
    {
        private readonly StevenDemoWebsiteContext _context;
        private readonly ICostCenterService _costCenterService;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;
        private readonly IProjectRequestService _projectRequestService;
        private readonly ILogger<ProjectRequestController> _logger;

        public ProjectRequestController(StevenDemoWebsiteContext context, IProjectRequestService projectRequestService,
            ICostCenterService costCenterService, IMapper mapper, IEmailService emailService, ILogger<ProjectRequestController> logger)
        {
            _context = context;
            // initialize all the Interface for Inversion of Control
            _projectRequestService = projectRequestService;

            _costCenterService = costCenterService;

            _mapper = mapper;
            _emailService = emailService;
            _logger = logger;
        }


        // GET: ProjectRequest
        /// <summary>
        ///     Index method which takes in searchName and searchPriority string and calls a service for the model and returns a
        ///     viewmodel to the view
        /// </summary>
        /// <param name="searchName">The name that matches the name in the database</param>
        /// <param name="searchPriority">Priority that matches the priority in the database</param>
        /// <returns>a View passed with PriorityLevelViewModel</returns>
        public async Task<IActionResult> Index(string searchName, string searchPriority)
        {
            // populate all the description of Cost Center
            await PopulateLookups();

            var priorityLevelModel = await _projectRequestService.Display(searchName, searchPriority);
            // map PriorityLevel to a PriorityLevel ViewModel
            var priorityLevelViewModel = _mapper.Map<PriorityLevelViewModel>(priorityLevelModel);

            return View(priorityLevelViewModel);
        }

        /// <summary>
        ///     Http GET request for the Details ActionResult
        /// </summary>
        /// <param name="id">nullable integer Id</param>
        /// <returns> a View passed with ProjectRequestViewModel</returns>
        // GET: ProjectRequest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            // call the service to retrieve the model from the context
            var projectRequestModel = await _projectRequestService.Get(id);
            if (projectRequestModel == null) return NotFound();


            // var viewModel = new ProjectRequestViewModel();
            // viewModel.DesiredCompletionDate = projectRequestModel.DesiredCompletionDate;
            // viewModel.EstimateTimeFrame = projectRequestModel.EstimateTimeFrame;
            // viewModel.Id = projectRequestModel.Id;
            // ....

            // (the mapper below does the job above)
            // maps ProjectRequest model to a ProjectReuqestViewModel
            var projectRequestViewModel = _mapper.Map<ProjectRequestViewModel>(projectRequestModel);

            return View(projectRequestViewModel);
        }

        /// <summary>
        ///     Http GET request for the Create ActionResult
        /// </summary>
        /// <returns>a view</returns>
        // GET: ProjectRequest/Create
        public async Task<IActionResult> Create()
        {
            // populate the departments
            await PopulateLookups();
            return View();
        }

        /// <summary>
        ///     Http POST request for Create ActionResult
        /// </summary>
        /// <param name="projectRequestViewModel">ProjectRequestViewModel Binded by acceptable fields</param>
        /// <returns>a View passed with ProjectRequestViewModel</returns>
        // POST: ProjectRequest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectRequestViewModel projectRequestViewModel)
        {
            if (ModelState.IsValid)
            {
                // first map ProjectRequestViewModel to a ProjectRequest
                var record = _mapper.Map<ProjectRequest>(projectRequestViewModel);

                // fill the department of the model with the string representation of comma-separated Ids of the Departments
                record.Departments =
                    projectRequestViewModel.DepartmentsId != null && projectRequestViewModel.DepartmentsId.Any()
                        ? string.Join(", ", projectRequestViewModel.DepartmentsId)
                        : "";
                // fill the BusinessJustification of the model by splitting the List<string> of ProjectRequestViewModel to comma separated string
                record.BusinessJustification = string.Join(", ", projectRequestViewModel.BusinessJustification);

                _logger.LogInformation("Service Adding Record");
                // call service to add all the records
                await _projectRequestService.Add(record);

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                _logger.LogInformation("Service Sending Email");
                // send creation email
                await _emailService.CreateEmail(record);
                stopwatch.Stop();
                _logger.LogInformation($"Email Sent in {stopwatch.ElapsedMilliseconds} ms");

                // return back to the Index
                return RedirectToAction(nameof(Index));
            }

            // if ModelState is not valid, then repopulate the description of CostCenter and return the ViewModel back to the same View again.
            await PopulateLookups();
            return View(projectRequestViewModel);
        }

        /// <summary>
        ///     Http GET request of Edit Action Result
        /// </summary>
        /// <param name="id">integer id</param>
        /// <returns>a View passed with ProjectRequestViewModel</returns>
        // GET: ProjectRequest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            _logger.LogInformation("Service Finding Entry");
            // call the projectRequestService to find the specific entry based on id
            var projectRequest = await _projectRequestService.Find(id);

            if (projectRequest == null)
            {
                _logger.LogWarning("Entry Not Found");
                return NotFound();
            }
            // map the ProjectRequest model to a ProjectRequestViewModel
            var projectRequestViewModel = _mapper.Map<ProjectRequestViewModel>(projectRequest);
            // split BusinessJustification into list
            projectRequestViewModel.BusinessJustification =
                new List<string>(projectRequest.BusinessJustification.Split(", "));
            // populate the departments
            await PopulateLookups(projectRequestViewModel);

            return View(projectRequestViewModel);
        }

        /// <summary>
        ///     Http POST request of Edit ActionResult
        /// </summary>
        /// <param name="id">Integer id of the entry</param>
        /// <param name="projectRequestViewModel">ViewModel binded by The allowed fields that can be passed through</param>
        /// <returns>RedirectToActionResult</returns>
        // POST: ProjectRequest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProjectRequestViewModel projectRequestViewModel)
        {
            if (id != projectRequestViewModel.Id) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    // first map ProjectRequestViewModel to a ProjectRequest
                    var record = _mapper.Map<ProjectRequest>(projectRequestViewModel);

                    // fill the department of the model with the string representation of comma-separated Ids of the Departments
                    record.Departments =
                        projectRequestViewModel.DepartmentsId != null && projectRequestViewModel.DepartmentsId.Any()
                            ? string.Join(", ", projectRequestViewModel.DepartmentsId)
                            : "";

                    // fill the BusinessJustification of the model by splitting the List<string> of ProjectRequestViewModel to comma separated string
                    record.BusinessJustification = string.Join(", ", projectRequestViewModel.BusinessJustification);

                    _logger.LogInformation("Service Updating Entry");
                    // call service to update the record
                    await _projectRequestService.Update(record);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StevenDemoTableExists(projectRequestViewModel.Id))
                    {
                        _logger.LogWarning("Entry Not Found");
                        return NotFound();
                    }
                    _logger.LogError("Concurrency Violation is Encountered");
                    throw;
                }

                // return back to Index View
                return RedirectToAction(nameof(Index));
            }

            // if ModelState is not valid, then repopulate the description of CostCenter and return the ViewModel back to the same View again.
            await PopulateLookups();
            return View(projectRequestViewModel);
        }

        /// <summary>
        ///     Http GET request for Delete action result
        /// </summary>
        /// <param name="id">integer id of the entry</param>
        /// <returns>a View passed with ProjectRequestViewModel</returns>
        // GET: ProjectRequest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                _logger.LogWarning("Entry Not Found");
                return NotFound();
            }
            // call the service to retrieve the Model based on the Id
            var projectRequestModel = await _projectRequestService.Get(id);
            // map the ProjectRequest Model to a ViewModel
            var projectRequestViewModel = _mapper.Map<ProjectRequestViewModel>(projectRequestModel);

            if (projectRequestModel == null)
            {
                _logger.LogWarning("Model Not Found");
                return NotFound();
            }
            return View(projectRequestViewModel);
        }

        /// <summary>
        ///     Http POST request to Delete the specific entry based on the Id
        /// </summary>
        /// <param name="id"> integer id of the entry</param>
        /// <returns>created RedirectToActionResult for the response</returns>
        // POST: ProjectRequest/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _logger.LogInformation("Service Deleting Entry");
            // call the projectRequestService to remove the entry based on the id
            var projectRequestViewModel = await _projectRequestService.Remove(id);
            // redirect to Index
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        ///     Private Helper Method to check whether the Table exists in the Context
        /// </summary>
        /// <param name="id">Integer Id</param>
        /// <returns>true if the database exist, false if otherwise</returns>
        private bool StevenDemoTableExists(int id)
        {
            return _context.ProjectRequest.Any(e => e.Id == id);
        }

        /// <summary>
        ///     Private helper method to populate all the departments to be displayed
        /// </summary>
        /// <param name="model"></param>
        /// <returns>task which populates the description with strings</returns>
        private async Task PopulateLookups(ProjectRequestViewModel model = null /*null if no model passed in */)
        {
            // map a list of CostCenter Model to a list of CostCenterViewModel based on the condition determined by the costCenterService
            var costCenterList = _mapper.Map<List<CostCenterViewModel>>(await _costCenterService.Get());
            // parse all the Departments to the list. ' ? :' operator evaluates the boolean expression and returns the result of one of two expressions
            // so if the model(nullable).departments is not null, then split departments to list based on comma, otherwise create a new list of string
            var costCentersIdList =
                model?.Departments != null ? model.Departments.Split(", ").ToList() : new List<string>();

            // select all the CostCenter based on ViewModel that fits the criteria  
            ViewData["CostCenters"] = costCenterList.Select(x => new SelectListItem
            {
                Value = x.Capitalized,
                Text = x.Capitalized,
                // choose to select only the departments that fits the name of the department
                Selected = costCentersIdList.Contains(x.Capitalized)
            });
        }
    }
}