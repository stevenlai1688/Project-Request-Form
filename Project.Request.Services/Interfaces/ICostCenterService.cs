using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Request.Services.Interfaces
{
    public interface ICostCenterService
    {
        Task<IEnumerable<CostCenter>> Get();
        Task<CostCenter> Add(CostCenter table);
        Task<CostCenter> Update(CostCenter table);
        Task<CostCenter> Delete(int? id);
    }
}
