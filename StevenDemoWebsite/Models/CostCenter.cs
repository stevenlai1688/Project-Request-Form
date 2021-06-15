using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class CostCenter
    {
        public CostCenter()
        {
            Areas = new HashSet<Area>();
            Branches = new HashSet<Branch>();
            Divisions = new HashSet<Division>();
            Employees = new HashSet<Employee>();
            HireFormWorkflows = new HashSet<HireFormWorkflow>();
            HireForms = new HashSet<HireForm>();
            IdeasInMotions = new HashSet<IdeasInMotion>();
            Regions = new HashSet<Region>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ReportsTo { get; set; }
        public bool? Primary { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<HireFormWorkflow> HireFormWorkflows { get; set; }
        public virtual ICollection<HireForm> HireForms { get; set; }
        public virtual ICollection<IdeasInMotion> IdeasInMotions { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
