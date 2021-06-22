using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Request.Data.Factory
{
    public interface IDbContextFactory
    {
        StevenDemoWebsiteContext create();
    }
}
