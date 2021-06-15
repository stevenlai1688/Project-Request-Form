using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ProductionPlanDiscipline
    {
        public int Id { get; set; }
        public string Discipline { get; set; }
        public int ProductionPlanId { get; set; }

        public virtual ProductionPlan ProductionPlan { get; set; }
    }
}
