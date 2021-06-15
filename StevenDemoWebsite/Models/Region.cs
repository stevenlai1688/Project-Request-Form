using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Region
    {
        public Region()
        {
            Areas = new HashSet<Area>();
            Branches = new HashSet<Branch>();
        }

        public int Id { get; set; }
        public int? ManagerId { get; set; }
        public int? CostCenterId { get; set; }
        public string Name { get; set; }
        public int? DivisionId { get; set; }
        public bool? Active { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual CostCenter CostCenter { get; set; }
        public virtual Division Division { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
