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
    public class CostCenterService : ICostCenterService
    {
        private readonly IDbContextFactory _context;
        public CostCenterService(IDbContextFactory context)
        {
            _context = context;
        }
        /// <summary>
        /// a Service Tasks that creates an entry to CostCenter Database of the context 
        /// </summary>
        /// <param name="table">CostCenter Entity Model</param>
        /// <returns>CostCenter Entity Model</returns>
        public async Task<CostCenter> Add(CostCenter table)
        {
            using (var context = _context.create())
            {
                context.Add(table);
                await context.SaveChangesAsync();
                return table;

            }

        }
        /// <summary>
        /// a Service Tasks that delete an entry to CostCenter Database of the context 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CostCenter> Delete(int? id)
        {
            // create new context everytime we call _context.create(),
            using (var context = _context.create())
            {
                var table = await context.CostCenter.SingleOrDefaultAsync(x => x.Id == id);
                context.CostCenter.Remove(table);
                await context.SaveChangesAsync();
                return table;
            }
        }
        /// <summary>
        /// a Service Tasks that retrieves an entry to CostCenter Database of the context based on Primary and Active Boolean expression 
        /// </summary>
        /// <returns>Enumerable Type of CostCenter</returns>
        // _context.CostCenter refers to the database, services retrieves database and return a type of entity model "CostCenter"
        public async Task<IEnumerable<CostCenter>> Get()
        {
            // create new context everytime we call _context.create(), using context factory to connect to different databases
            using (var context = _context.create())
            {
                return await context.CostCenter.Where(p => (bool)p.Primary).Where(w => w.Active)
                    .OrderBy(x => x.Description).ToListAsync();
            }
            
        }
        /// <summary>
        /// a Service Tasks that Updates an entry to CostCenter Database of the context
        /// </summary>
        /// <param name="table">CostCenter Entity Model</param>
        /// <returns>CostCenter Entity Model</returns>
        public async Task<CostCenter> Update(CostCenter table)
        {
            using (var context = _context.create())
            {
                context.Update(table);
                await context.SaveChangesAsync();
                return table;
            }
        }
    }
}
