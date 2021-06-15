using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ProductionPlanProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompletedBy { get; set; }
        public int ProductionPlanId { get; set; }

        public virtual ProductionPlan ProductionPlan { get; set; }
    }
}
