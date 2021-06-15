using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Division
    {
        public Division()
        {
            Regions = new HashSet<Region>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ManagerId { get; set; }
        public int? CostCenterId { get; set; }
        public bool? Active { get; set; }
        public string Disclaimer { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual CostCenter CostCenter { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
