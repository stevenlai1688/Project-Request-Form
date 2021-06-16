using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Request.Services.Interfaces
{
    public interface IProjectRequestService
    {
        Task<StevenDemoTable> Get(int? id);
        Task<PriorityLevel> Display(string searchName, string searchPriority);
        Task<StevenDemoTable> Update(StevenDemoTable table);
        Task<StevenDemoTable> Create(StevenDemoTable table);
    }
}
