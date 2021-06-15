using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StevenDemoWebsite.Data;
using StevenDemoWebsite.Models;

namespace StevenDemoWebsite.Controllers
{
    public class StevenDemoTablesController : Controller
    {
        private readonly StevenDemoWebsiteContext _context;

        public StevenDemoTablesController(StevenDemoWebsiteContext context)
        {
            _context = context;
        }

        // GET: StevenDemoTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.StevenDemoTable.ToListAsync());
        }

        // GET: StevenDemoTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stevenDemoTable = await _context.StevenDemoTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stevenDemoTable == null)
            {
                return NotFound();
            }

            return View(stevenDemoTable);
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
        public async Task<IActionResult> Create([Bind("Id,RequestReason,RequestorName,DesiredCompletionDate,PriorityLevel,RequestDescription, RequestChanges")] StevenDemoTable stevenDemoTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stevenDemoTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stevenDemoTable);
        }

        // GET: StevenDemoTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stevenDemoTable = await _context.StevenDemoTable.FindAsync(id);
            if (stevenDemoTable == null)
            {
                return NotFound();
            }
            return View(stevenDemoTable);
        }

        // POST: StevenDemoTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RequestReason,RequestorName,DesiredCompletionDate,PriorityLevel,RequestDescription, RequestChanges")] StevenDemoTable stevenDemoTable)
        {
            if (id != stevenDemoTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stevenDemoTable);
                    await _context.SaveChangesAsync();
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
            return View(stevenDemoTable);
        }

        // GET: StevenDemoTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stevenDemoTable = await _context.StevenDemoTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stevenDemoTable == null)
            {
                return NotFound();
            }

            return View(stevenDemoTable);
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
