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
        public async Task<CostCenter> Add(CostCenter table)
        {
            using (var context = _context.create())
            {
                context.Add(table);
                await context.SaveChangesAsync();
                return table;

            }

        }

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
