using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StevenDemoWebsite.Models;

namespace StevenDemoWebsite.Data
{
    public class StevenDemoWebsiteContext : DbContext
    {
        public StevenDemoWebsiteContext (DbContextOptions<StevenDemoWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<StevenDemoWebsite.Models.StevenDemoTable> StevenDemoTable { get; set; }
    }
}
