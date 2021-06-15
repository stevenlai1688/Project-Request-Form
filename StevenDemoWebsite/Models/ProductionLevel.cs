using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ProductionLevel
    {
        public ProductionLevel()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string ProductionLevel1 { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
