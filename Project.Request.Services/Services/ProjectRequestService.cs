using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using Project.Request.Data.Factory;
using Project.Request.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Request.Services.Services
{
    public class ProjectRequestService : IProjectRequestService
    {
        private readonly IDbContextFactory _context;

        public ProjectRequestService(IDbContextFactory context)
        {
            _context = context;
        }
        public async Task<ProjectRequest> Get(int? id)
        {
            using (var context = _context.create())
            {
                var stevenDemoTable = await context.StevenDemoTable
                .FirstOrDefaultAsync(m => m.Id == id);

                return stevenDemoTable;
            }

        }

        public async Task<PriorityLevel> Display(string searchName, string searchPriority)
        {
            using (var context = _context.create())
            {
                // search for name
                var names = from i in context.StevenDemoTable
                            select i;
                // get a list of priority levels using LINQ
                IQueryable<string> priorityQuery = from p in context.StevenDemoTable
                                                   select p.PriorityLevel;

                if (!String.IsNullOrEmpty(searchName))
                {
                    // check where string name matches
                    names = names.Where(s => s.RequestorName.Contains(searchName));
                }
                if (!String.IsNullOrEmpty(searchPriority))
                {
                    // check where priority level matches
                    names = names.Where(x => x.PriorityLevel == searchPriority);
                }


                var priorityLevel = new PriorityLevel
                {
                    // the priority is based on the different priority level, it is based on the ordering of P.L. in the index
                    Priority = new SelectList(await priorityQuery.Distinct().ToListAsync()),
                    // separate tables based on the priority level
                    ProjectRequestTables = await names.ToListAsync()
                };

                return priorityLevel;
            }
        }
        public async Task<ProjectRequest> Update(ProjectRequest projectRequestTable)
        {
            using (var context = _context.create())
            {
                context.Update(projectRequestTable);
                await context.SaveChangesAsync();
                return projectRequestTable;
            }
        }
        public async Task<ProjectRequest> Add(ProjectRequest projectRequestTable)
        {
            using (var context = _context.create())
            {
                context.Add(projectRequestTable);
                await context.SaveChangesAsync();
                return projectRequestTable;
            }
        }
        public async Task<ProjectRequest> Remove(int id)
        {
            using (var context = _context.create())
            {
                var projectRequestTable = await Find(id);
                context.StevenDemoTable.Remove(projectRequestTable);
                await context.SaveChangesAsync();
                return projectRequestTable;
            }
        }
        public async Task<ProjectRequest> Find (int? id)
        {
            using(var context = _context.create())
            {
                return await context.StevenDemoTable.FindAsync(id);
            }
        }
    }
}
