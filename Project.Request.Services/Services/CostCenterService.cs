using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Request.Data.Factory;
using Project.Request.Models.DataModels;
using Project.Request.Services.Interfaces;

namespace Project.Request.Services.Services
{
    public class CostCenterService : ICostCenterService
    {
        private readonly IDbContextFactory _context;

        public CostCenterService(IDbContextFactory context)
        {
            _context = context;
        }

        /// <summary>
        ///     a Service Tasks that creates an entry to CostCenter Database of the context
        /// </summary>
        /// <param name="table">CostCenter Entity Model</param>
        /// <returns>CostCenter Entity Model</returns>
        public async Task<CostCenter> Add(CostCenter table)
        {
            await using var context = _context.Create();
            context.Add(table);
            await context.SaveChangesAsync();
            return table;
        }

        /// <summary>
        ///     a Service Tasks that delete an entry to CostCenter Database of the context
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CostCenter> Delete(int? id)
        {
            // create new context everytime we call _context.create(),
            await using var context = _context.Create();
            var table = await context.CostCenter.SingleOrDefaultAsync(x => x.Id == id);
            context.CostCenter.Remove(table);
            await context.SaveChangesAsync();
            return table;
        }

        /// <summary>
        ///     a Service Tasks that retrieves an entry to CostCenter Database of the context based on Primary and Active Boolean
        ///     expression
        /// </summary>
        /// <returns>Enumerable Type of CostCenter</returns>
        // _context.CostCenter refers to the database, services retrieves database and return a type of entity model "CostCenter"
        public async Task<IEnumerable<CostCenter>> Get()
        {
            // create new context everytime we call _context.create(), using context factory to connect to different databases
            await using var context = _context.Create();
            return await context.CostCenter.Where(p => (bool) p.Primary).Where(w => w.Active)
                .OrderBy(x => x.Description).ToListAsync();
        }

        /// <summary>
        ///     a Service Tasks that Updates an entry to CostCenter Database of the context
        /// </summary>
        /// <param name="table">CostCenter Entity Model</param>
        /// <returns>CostCenter Entity Model</returns>
        public async Task<CostCenter> Update(CostCenter table)
        {
            await using var context = _context.Create();
            context.Update(table);
            await context.SaveChangesAsync();
            return table;
        }

        public async Task<CostCenter> Get(int? id)
        {
            await using var context = _context.Create();
            return await context.CostCenter.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}