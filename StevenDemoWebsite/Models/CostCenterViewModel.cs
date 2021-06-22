using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CostCenterViewModel
    {
        [DisplayName("Id")] 
        public int Id { get; set; }
        [DisplayName("Code")] 
        public string Code { get; set; }
        [DisplayName("Description")] 
        public string Description { get; set; }
        [DisplayName("Active")]
        public bool Active { get; set; }
        [DisplayName("Modified By")] 
        public string ModifiedBy { get; set; }
        [DisplayName("Modified Date")] 
        public DateTime? ModifiedDate { get; set; }

    }
}
