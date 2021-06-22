using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using Project.Request.Services.Interfaces;

namespace Project.Controllers
{

    public class ProjectRequestController : Controller
    {
        private readonly StevenDemoWebsiteContext _context;
        private readonly IProjectRequestService projectRequestService;
        private readonly ICostCenterService costCenterService;
        private readonly IMapper _mapper;

        public ProjectRequestController(StevenDemoWebsiteContext context, IProjectRequestService projectRequestService, ICostCenterService costCenterService, IMapper mapper)
        {

            _context = context;

            this.projectRequestService = projectRequestService;

            this.costCenterService = costCenterService;

            this._mapper = mapper;
        }


        // GET: StevenDemoTables
        public async Task<IActionResult> Index(string searchName, string searchPriority)
        {
            await PopulateLookups();

            var priorityLevel = await projectRequestService.Display(searchName, searchPriority);

            var priorityLevelVM = _mapper.Map<PriorityLevelViewModel>(priorityLevel);

            return View(priorityLevelVM);
        }

        // GET: StevenDemoTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRequestViewModel = await projectRequestService.Get(id);
            if (projectRequestViewModel == null)
            {
                return NotFound();
            }


            //var viewModel = new ProjectRequestViewModel();
            //viewModel.DesiredCompletionDate = stevenDemoTable.DesiredCompletionDate;
            //viewModel.EstimateTimeFrame = stevenDemoTable.EstimateTimeFrame;
            //viewModel.Id = stevenDemoTable.Id;

            // mapper to do the job above
            var viewModel = _mapper.Map<ProjectRequestViewModel>(projectRequestViewModel);



            return View(viewModel);
        }

        // GET: StevenDemoTables/Create
        public async Task<IActionResult> Create()
        {
            // populate the departments
            await PopulateLookups();
            return View();
        }

        // POST: StevenDemoTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RequestReason,RequestorName,DesiredCompletionDate,PriorityLevel,RequestDescription,RequestChanges,RequestEffectsOnOrganization,EstimateTimeFrame, BusinessJustification, DepartmentsId, Departments")] ProjectRequestViewModel projectRequestViewModel)
        {
            if (ModelState.IsValid)
            {


                // first map ProjectRequestViewModel to a ProjectRequest
                var record = _mapper.Map<ProjectRequest>(projectRequestViewModel);
                // add departments
                record.Departments = projectRequestViewModel.DepartmentsId != null && projectRequestViewModel.DepartmentsId.Any() ? string.Join(",", projectRequestViewModel.DepartmentsId) : "";
                // split List<string> to comma separated string
                record.BusinessJustification = string.Join(",", projectRequestViewModel.BusinessJustification);
                // call service
                


                await projectRequestService.Add(record);

                return RedirectToAction(nameof(Index));
            
            }           

            return View(projectRequestViewModel);
        }

        // GET: StevenDemoTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // populate the departments
            await PopulateLookups();
            var projectRequest = await _context.StevenDemoTable.FindAsync(id);
            
            if (projectRequest == null)
            {
                return NotFound();
            }
            var projectRequestViewModel = _mapper.Map<ProjectRequestViewModel>(projectRequest);


            return View(projectRequestViewModel);
        }

        // POST: StevenDemoTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RequestReason,RequestorName,DesiredCompletionDate,PriorityLevel,RequestDescription,RequestChanges,RequestEffectsOnOrganization,EstimateTimeFrame, BusinessJustification, DepartmentsId, Departments")] ProjectRequestViewModel projectRequestViewModel)
        {
            
            if (id != projectRequestViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // first map ProjectRequestViewModel to a ProjectRequest
                    var record = _mapper.Map<ProjectRequest>(projectRequestViewModel);

                    record.Departments = projectRequestViewModel.DepartmentsId != null && projectRequestViewModel.DepartmentsId.Any() ? string.Join(",", projectRequestViewModel.DepartmentsId) : "";

                    // split List<string> to comma separated string
                    record.BusinessJustification = string.Join(",", projectRequestViewModel.BusinessJustification);
                    // call service
                    await projectRequestService.Update(record);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StevenDemoTableExists(projectRequestViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            
            return View(projectRequestViewModel);
        }

        // GET: StevenDemoTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRequestViewModel = await projectRequestService.Get(id);
            var viewModel = _mapper.Map<ProjectRequestViewModel>(projectRequestViewModel);

            if (projectRequestViewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // POST: StevenDemoTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectRequestViewModel = await projectRequestService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool StevenDemoTableExists(int id)
        {
            return _context.StevenDemoTable.Any(e => e.Id == id);
        }



        // private helper method to populate all the departments
        private async Task PopulateLookups(ProjectRequestViewModel model = null /*null if no model passed in */)
        {
            var costCenterList = _mapper.Map<List<CostCenterViewModel>>(await costCenterService.Get());
            var costCentersIdList = model?.Departments != null ? model.Departments.Split(",").ToList() : new List<string>();
            
            ViewData["CostCenters"] = costCenterList.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Description,
                // choose to display only the departments
                Selected = costCentersIdList.Contains(x.Id.ToString())
            });
           
        }
    }
}
