using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class HireFormWorkflow
    {
        public HireFormWorkflow()
        {
            HireFormFiles = new HashSet<HireFormFile>();
        }

        public int Id { get; set; }
        public int PositionId { get; set; }
        public string JobTitle { get; set; }
        public string Status { get; set; }
        public string PositionManager { get; set; }
        public int CostCenterId { get; set; }
        public int Location { get; set; }
        public string NeedExplanation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? AnticipatedStartDate { get; set; }
        public string PhysicalLocation { get; set; }
        public string PermanentLocation { get; set; }
        public string EffectiveLocation { get; set; }
        public string ReferredBy { get; set; }
        public double? AnnualSalary { get; set; }
        public double? HourlyRate { get; set; }
        public double? FlatRate { get; set; }
        public string Bps { get; set; }
        public string IntroductoryBps { get; set; }
        public string BaseBps { get; set; }
        public string Duration { get; set; }
        public int? Tiers { get; set; }
        public double? MaxCommission { get; set; }
        public bool? Guarantees { get; set; }
        public double? Month1Guaranty { get; set; }
        public double? Month2Guaranty { get; set; }
        public double? Month3Guaranty { get; set; }
        public int? FilesOriginatedMonth1Guaranty { get; set; }
        public int? FilesOriginatedMonth2Guaranty { get; set; }
        public int? FilesClosedGuaranty { get; set; }
        public bool? TemporaryDraw { get; set; }
        public double? Month1Draw { get; set; }
        public double? Month2Draw { get; set; }
        public double? Month3Draw { get; set; }
        public int? FilesOriginatedMonth1Draw { get; set; }
        public int? FilesOriginatedMonth2Draw { get; set; }
        public int? FilesClosedDraw { get; set; }
        public string SigningBonus { get; set; }
        public double? CommissionTypeValue { get; set; }
        public string CommissionType { get; set; }
        public double? AdditionalCredit { get; set; }
        public string AdditionalTerms { get; set; }
        public string SubmittedByUsername { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CostCenter CostCenter { get; set; }
        public virtual Branch LocationNavigation { get; set; }
        public virtual EmployeeType Position { get; set; }
        public virtual ICollection<HireFormFile> HireFormFiles { get; set; }
    }
}
