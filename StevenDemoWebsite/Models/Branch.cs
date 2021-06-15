using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Branch
    {
        public Branch()
        {
            AssociatedBranches = new HashSet<AssociatedBranch>();
            BusinessReviews = new HashSet<BusinessReview>();
            ChecklistBranchChangeLogs = new HashSet<ChecklistBranchChangeLog>();
            ChecklistBranchResponses = new HashSet<ChecklistBranchResponse>();
            EmployeeBranches = new HashSet<Employee>();
            EmployeeReportingBranches = new HashSet<Employee>();
            HireFormWorkflows = new HashSet<HireFormWorkflow>();
            HireForms = new HashSet<HireForm>();
            InverseReportingBranch = new HashSet<Branch>();
            OnBoardingBranchComments = new HashSet<OnBoardingBranchComment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CostCenterId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int? ManagerId { get; set; }
        public bool? Active { get; set; }
        public int? RegionId { get; set; }
        public string NmlsId { get; set; }
        public int? ReportingBranchId { get; set; }
        public int? AreaId { get; set; }
        public string Phone { get; set; }
        public string SimpleName { get; set; }
        public string DisplayName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string LicensingInfo { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public string Disclosure { get; set; }
        public string Disclaimer { get; set; }

        public virtual Area Area { get; set; }
        public virtual CostCenter CostCenter { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual Region Region { get; set; }
        public virtual Branch ReportingBranch { get; set; }
        public virtual ICollection<AssociatedBranch> AssociatedBranches { get; set; }
        public virtual ICollection<BusinessReview> BusinessReviews { get; set; }
        public virtual ICollection<ChecklistBranchChangeLog> ChecklistBranchChangeLogs { get; set; }
        public virtual ICollection<ChecklistBranchResponse> ChecklistBranchResponses { get; set; }
        public virtual ICollection<Employee> EmployeeBranches { get; set; }
        public virtual ICollection<Employee> EmployeeReportingBranches { get; set; }
        public virtual ICollection<HireFormWorkflow> HireFormWorkflows { get; set; }
        public virtual ICollection<HireForm> HireForms { get; set; }
        public virtual ICollection<Branch> InverseReportingBranch { get; set; }
        public virtual ICollection<OnBoardingBranchComment> OnBoardingBranchComments { get; set; }
    }
}
