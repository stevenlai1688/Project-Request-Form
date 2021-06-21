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
        Task<ProjectRequest> Get(int? id);
        Task<PriorityLevel> Display(string searchName, string searchPriority);
        Task<ProjectRequest> Update(ProjectRequest table);
        Task<ProjectRequest> Add(ProjectRequest table);
        Task<ProjectRequest> Remove(int id);
    }
}
