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
    
    public class StevenDemoTablesController : Controller
    {
        private readonly StevenDemoWebsiteContext _context;
        private readonly IProjectRequestService projectRequestService;
        private readonly IMapper _mapper;

        public StevenDemoTablesController(StevenDemoWebsiteContext context, IProjectRequestService projectRequestService, IMapper mapper)
        {

            _context = context;
            this.projectRequestService = projectRequestService;
            this._mapper = mapper;
        }
       
     
        // GET: StevenDemoTables
        public async Task<IActionResult> Index(string searchName, string searchPriority)
        {

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

            var stevenDemoTable = await projectRequestService.Get(id);
            if (stevenDemoTable == null)
            {
                return NotFound();
            }


            //var viewModel = new StevenDemoTableViewModel();
            //viewModel.DesiredCompletionDate = stevenDemoTable.DesiredCompletionDate;
            //viewModel.EstimateTimeFrame = stevenDemoTable.EstimateTimeFrame;
            //viewModel.Id = stevenDemoTable.Id;

            // mapper to do the job above
            var viewModel = _mapper.Map<StevenDemoTableViewModel>(stevenDemoTable);

            

            return View(viewModel);
        }

        // GET: StevenDemoTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StevenDemoTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RequestReason,RequestorName,DesiredCompletionDate,PriorityLevel,RequestDescription,RequestChanges,RequestEffectsOnOrganization,EstimateTimeFrame")] StevenDemoTable stevenDemoTable)
        {
            if (ModelState.IsValid)
            {
                stevenDemoTable = await projectRequestService.Create(stevenDemoTable);
                return RedirectToAction(nameof(Index));
            }

            var viewModel = _mapper.Map<StevenDemoTableViewModel>(stevenDemoTable);

            return View(viewModel);
        }

        // GET: StevenDemoTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //
            var stevenDemoTable = await _context.StevenDemoTable.FindAsync(id);
            if (stevenDemoTable == null)
            {
                return NotFound();
            }
            var viewModel = _mapper.Map<StevenDemoTableViewModel>(stevenDemoTable);

            return View(viewModel);
        }

        // POST: StevenDemoTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RequestReason,RequestorName,DesiredCompletionDate,PriorityLevel,RequestDescription,RequestChanges,RequestEffectsOnOrganization,EstimateTimeFrame")] StevenDemoTable stevenDemoTable)
        {
            if (id != stevenDemoTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                     var table = await projectRequestService.Update(stevenDemoTable);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StevenDemoTableExists(stevenDemoTable.Id))
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
            var viewModel = _mapper.Map<StevenDemoTableViewModel>(stevenDemoTable);
            return View(viewModel);
        }

        // GET: StevenDemoTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stevenDemoTable = await projectRequestService.Get(id);
            var viewModel = _mapper.Map<StevenDemoTableViewModel>(stevenDemoTable);

            if (stevenDemoTable == null)
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
            var stevenDemoTable = await _context.StevenDemoTable.FindAsync(id);
            _context.StevenDemoTable.Remove(stevenDemoTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StevenDemoTableExists(int id)
        {
            return _context.StevenDemoTable.Any(e => e.Id == id);
        }
    }
}
