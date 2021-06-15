using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ProductionPlan
    {
        public ProductionPlan()
        {
            ProductionPlanDisciplines = new HashSet<ProductionPlanDiscipline>();
            ProductionPlanProjects = new HashSet<ProductionPlanProject>();
        }

        public int Id { get; set; }
        public string Theme { get; set; }
        public int Year { get; set; }
        public string ProductionLevelFirstQuarter { get; set; }
        public string ProductionLevelSecondQuarter { get; set; }
        public string ProductionLevelThirdQuarter { get; set; }
        public string ProductionLevelFourthQuarter { get; set; }
        public int AppsPerWeekFirstQuarter { get; set; }
        public int AppsPerWeekSecondQuarter { get; set; }
        public int AppsPerWeekThirdQuarter { get; set; }
        public int AppsPerWeekFourthQuarter { get; set; }
        public int LeadsPerWeekFirstQuarter { get; set; }
        public int LeadsPerWeekSecondQuarter { get; set; }
        public int LeadsPerWeekThirdQuarter { get; set; }
        public int LeadsPerWeekFourthQuarter { get; set; }
        public int JanuaryPurchaseUnits { get; set; }
        public int JanuaryRefinanceUnits { get; set; }
        public decimal JanuaryVolume { get; set; }
        public int FebruaryPurchaseUnits { get; set; }
        public int FebruaryRefinanceUnits { get; set; }
        public decimal FebruaryVolume { get; set; }
        public int MarchPurchaseUnits { get; set; }
        public int MarchRefinanceUnits { get; set; }
        public decimal MarchVolume { get; set; }
        public int AprilPurchaseUnits { get; set; }
        public int AprilRefinanceUnits { get; set; }
        public decimal AprilVolume { get; set; }
        public int MayPurchaseUnits { get; set; }
        public int MayRefinanceUnits { get; set; }
        public decimal MayVolume { get; set; }
        public int JunePurchaseUnits { get; set; }
        public int JuneRefinanceUnits { get; set; }
        public decimal JuneVolume { get; set; }
        public int JulyPurchaseUnits { get; set; }
        public int JulyRefinanceUnits { get; set; }
        public decimal JulyVolume { get; set; }
        public int AugustPurchaseUnits { get; set; }
        public int AugustRefinanceUnits { get; set; }
        public decimal AugustVolume { get; set; }
        public int SeptemberPurchaseUnits { get; set; }
        public int SeptemberRefinanceUnits { get; set; }
        public decimal SeptemberVolume { get; set; }
        public int OctoberPurchaseUnits { get; set; }
        public int OctoberRefinanceUnits { get; set; }
        public decimal OctoberVolume { get; set; }
        public int NovemberPurchaseUnits { get; set; }
        public int NovemberRefinanceUnits { get; set; }
        public decimal NovemberVolume { get; set; }
        public int DecemberPurchaseUnits { get; set; }
        public int DecemberRefinanceUnits { get; set; }
        public decimal DecemberVolume { get; set; }
        public DateTime? UpdateSentOn { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<ProductionPlanDiscipline> ProductionPlanDisciplines { get; set; }
        public virtual ICollection<ProductionPlanProject> ProductionPlanProjects { get; set; }
    }
}
