using Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project.Request.Web.Models;

namespace Project.Request.Data.Factory
{
    public class DbContextFactory : IDbContextFactory
    {
        private readonly IOptions<ConnectionStrings> _connectionStrings;
        public DbContextFactory(IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }
        StevenDemoWebsiteContext IDbContextFactory.create()
        {
            var optionsBuilder = new DbContextOptionsBuilder<StevenDemoWebsiteContext>();
            optionsBuilder.UseSqlServer(_connectionStrings.Value.OperationalConnection);
            return new StevenDemoWebsiteContext(optionsBuilder.Options);
        }
    }
}
