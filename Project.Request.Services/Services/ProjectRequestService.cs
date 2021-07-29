using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Request.Data.Factory;
using Project.Request.Models.DataModels;
using Project.Request.Services.Interfaces;
using System.Linq;
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

        /// <summary>
        ///     a Service Task that returns a ProjectRequest Entity Model based on matching Id
        /// </summary>
        /// <param name="id">nullable integer Id that matches with the entry</param>
        /// <returns>PriorityLevel Entity model</returns>
        public async Task<ProjectRequest> Get(int? id)
        {
            await using var context = _context.Create();
            // retrieves the matching id entry from the context table
            var projectRequestTable = await context.ProjectRequest
                .FirstOrDefaultAsync(m => m.Id == id);

            return projectRequestTable;
        }

        /// <summary>
        ///     a Service Task that takes a searchName and searchPriority and returns a PriorityLevel Entity Model
        /// </summary>
        /// <param name="searchName">string name to be searched</param>
        /// <param name="searchPriority">string priority level to be searched</param>
        /// <returns>PriorityLevel Entity model</returns>
        public async Task<PriorityLevel> Display(string searchName, string searchPriority)
        {
            await using var context = _context.Create();
            // search for name
            var names = from i in context.ProjectRequest
                select i;
            // get a list of priority levels using LINQ
            var priorityQuery = from p in context.ProjectRequest
                select p.PriorityLevel;

            if (!string.IsNullOrEmpty(searchName))
                // check where string name matches
                names = names.Where(s => s.RequestorName.Contains(searchName));
            if (!string.IsNullOrEmpty(searchPriority))
                // check where priority level matches
                names = names.Where(x => x.PriorityLevel == searchPriority);

            // create a new PriorityLevel Entity Model to be returned
            var priorityLevel = new PriorityLevel
            {
                // the priority is based on the different priority level, it is based on the ordering of P.L. in the index
                Priority = new SelectList(await priorityQuery.Distinct().ToListAsync()),
                // separate tables based on the priority level
                ProjectRequestTables = await names.ToListAsync()
            };

            return priorityLevel;
        }

        /// <summary>
        ///     a Service Tasks that Updates the database given an Entity model object
        /// </summary>
        /// <param name="projectRequestTable">a ProjectRequest Entity Model object</param>
        /// <returns>a ProjectRequest Entity Model object</returns>
        public async Task<ProjectRequest> Update(ProjectRequest projectRequestTable)
        {

            await using var context = _context.Create();

            // update the context table
            context.Update(projectRequestTable);
            // save the changes
            await context.SaveChangesAsync();

            return projectRequestTable;
        }

        /// <summary>
        ///     a Service Task that adds an entry to database given an Entity model object
        /// </summary>
        /// <param name="projectRequestTable">ProjectRequest Entity Model object</param>
        /// <returns>a ProjectRequest Entity Model object</returns>
        public async Task<ProjectRequest> Add(ProjectRequest projectRequestTable)
        {
            await using var context = _context.Create();
            // add the new entry into the context
            context.Add(projectRequestTable);
            // save the changes
            await context.SaveChangesAsync();

            return projectRequestTable;
        }

        /// <summary>
        ///     a Service Task that Deletes an entry to database given a Entity model object
        /// </summary>
        /// <param name="id">integer id of the entry</param>
        /// <returns>ProjectRequest Entity Model object</returns>
        public async Task<ProjectRequest> Remove(int id)
        {
            await using var context = _context.Create();
            // find the entry based on the id
            var projectRequestTable = await Find(id);
            // remove the table from the context 
            context.ProjectRequest.Remove(projectRequestTable);
            // save the changes
            await context.SaveChangesAsync();

            return projectRequestTable;
        }

        /// <summary>
        ///     a Service Task that Finds an entry in the database given an Id
        /// </summary>
        /// <param name="id">integer id of the entry</param>
        /// <returns>a ProjectRequest Entity Model object</returns>
        public async Task<ProjectRequest> Find(int? id)
        {
            await using var context = _context.Create();
            // Find and return an entity with the primary key id value
            return await context.ProjectRequest.FindAsync(id);
        }
    }
}