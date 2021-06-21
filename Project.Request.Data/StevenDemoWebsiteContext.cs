using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class StevenDemoWebsiteContext : DbContext
    {
        public StevenDemoWebsiteContext (DbContextOptions<StevenDemoWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<Project.Models.ProjectRequest> StevenDemoTable { get; set; }

    }
}
