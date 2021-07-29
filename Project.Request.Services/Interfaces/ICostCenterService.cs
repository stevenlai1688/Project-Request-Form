using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Request.Models.DataModels;

namespace Project.Request.Services.Interfaces
{
    public interface ICostCenterService
    {
        Task<IEnumerable<CostCenter>> Get();
        Task<CostCenter> Add(CostCenter table);
        Task<CostCenter> Update(CostCenter table);
        Task<CostCenter> Delete(int? id);
        Task<CostCenter> Get(int? id);
    }
}