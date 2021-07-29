using Microsoft.EntityFrameworkCore;
using Project.Request.Models.DataModels;

namespace Project.Request.Data
{
    public class StevenDemoWebsiteContext : DbContext
    {
        public StevenDemoWebsiteContext(DbContextOptions<StevenDemoWebsiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProjectRequest> ProjectRequest { get; set; }
        public virtual DbSet<CostCenter> CostCenter { get; set; }
    }
}   