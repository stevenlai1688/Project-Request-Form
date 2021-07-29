using System.Threading.Tasks;
using Project.Request.Models.DataModels;

namespace Project.Request.Services.Interfaces
{
    public interface IProjectRequestService
    {
        Task<ProjectRequest> Get(int? id);
        Task<PriorityLevel> Display(string searchName, string searchPriority);
        Task<ProjectRequest> Update(ProjectRequest table);
        Task<ProjectRequest> Add(ProjectRequest table);
        Task<ProjectRequest> Remove(int id);
        Task<ProjectRequest> Find(int? id);
    }
}