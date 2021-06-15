using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class CombinedView
    {
        public int Id { get; set; }
        public string AdpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AkaFirstName { get; set; }
        public string AkaLastName { get; set; }
        public bool? UseAkaname { get; set; }
        public bool Active { get; set; }
        public string ManagerName { get; set; }
        public string ManagerEmail { get; set; }
        public string SalesManagerName { get; set; }
        public string SalesManagerEmail { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Type { get; set; }
        public string CostCenter { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string Division { get; set; }
        public string NmlsId { get; set; }
        public bool? Producing { get; set; }
        public decimal? MarketingCreditCap { get; set; }
        public int? ProductionLevelId { get; set; }
        public DateTime? AscentEnrollmentDate { get; set; }
        public bool? CustomerSurvey { get; set; }
        public bool? SocialSurvey { get; set; }
        public bool? Qplp { get; set; }
        public bool? Cplp { get; set; }
        public string ReportingBranch { get; set; }
        public string EmployeeType { get; set; }
        public string UserName { get; set; }
        public string BranchManagerUserName { get; set; }
        public string ReportingBranchManagerUserName { get; set; }
        public string RegionManagerUserName { get; set; }
        public string DivisionManagerUserName { get; set; }
        public string AreaName { get; set; }
        public string AreaManagerName { get; set; }
        public string AreaManagerUserName { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeeEmail { get; set; }
        public string UserEmail { get; set; }
        public string BranchManagerEmail { get; set; }
        public string ReportingBranchManagerEmail { get; set; }
        public string RegionManagerEmail { get; set; }
        public string DivisionManagerEmail { get; set; }
        public string AreaManagerEmail { get; set; }
        public string AkaFirstLast { get; set; }
        public string AkaLastFirst { get; set; }
        public string CFirstLast { get; set; }
        public string CLastFirst { get; set; }
    }
}
