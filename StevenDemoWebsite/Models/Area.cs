using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Area
    {
        public Area()
        {
            Branches = new HashSet<Branch>();
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CostCenterId { get; set; }
        public int? ManagerId { get; set; }
        public bool? Active { get; set; }
        public int? RegionId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual CostCenter CostCenter { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
