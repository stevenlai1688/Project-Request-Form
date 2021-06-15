using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Areas = new HashSet<Area>();
            AssociatedBranches = new HashSet<AssociatedBranch>();
            Branches = new HashSet<Branch>();
            BusinessReviews = new HashSet<BusinessReview>();
            ChecklistBranchChangeLogs = new HashSet<ChecklistBranchChangeLog>();
            ChecklistBranchResponses = new HashSet<ChecklistBranchResponse>();
            ChecklistChangeLogCurrentUsers = new HashSet<ChecklistChangeLog>();
            ChecklistChangeLogEmployees = new HashSet<ChecklistChangeLog>();
            ChecklistResponseCheckedByUsers = new HashSet<ChecklistResponse>();
            ChecklistResponseEmployees = new HashSet<ChecklistResponse>();
            CommentCreatedByNavigations = new HashSet<Comment>();
            CommentCreatedForNavigations = new HashSet<Comment>();
            Divisions = new HashSet<Division>();
            EmployeeFiles = new HashSet<EmployeeFile>();
            EncompassEmailOptOuts = new HashSet<EncompassEmailOptOut>();
            HourlyRates = new HashSet<HourlyRate>();
            IdeaInMotionComments = new HashSet<IdeaInMotionComment>();
            IdeasInMotions = new HashSet<IdeasInMotion>();
            InverseManager = new HashSet<Employee>();
            ItchangeMatrices = new HashSet<ItchangeMatrix>();
            OnBoardingBranchComments = new HashSet<OnBoardingBranchComment>();
            ProductionPlans = new HashSet<ProductionPlan>();
            RateDisclaimers = new HashSet<RateDisclaimer>();
            Regions = new HashSet<Region>();
            StateDisclaimers = new HashSet<StateDisclaimer>();
            TicketEmployees = new HashSet<Ticket>();
            TicketHistories = new HashSet<TicketHistory>();
            TicketModifiedByNavigations = new HashSet<Ticket>();
            TicketSubmittingFors = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string AdpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AkaFirstName { get; set; }
        public string AkaLastName { get; set; }
        public string AkaName { get; set; }
        public bool? UseAkaname { get; set; }
        public bool Active { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ManagerId { get; set; }
        public int? SalesManagerId { get; set; }
        public int? Type { get; set; }
        public int? CostCenterId { get; set; }
        public int? BranchId { get; set; }
        public int? ReportingBranchId { get; set; }
        public string JobTitle { get; set; }
        public int? AreaId { get; set; }
        public string NmlsId { get; set; }
        public DateTime? SignatureOverrideDate { get; set; }
        public bool? Producing { get; set; }
        public decimal? MarketingCreditCap { get; set; }
        public int? ProductionLevelId { get; set; }
        public DateTime? AscentEnrollmentDate { get; set; }
        public bool? CustomerSurvey { get; set; }
        public bool? SocialSurvey { get; set; }
        public bool? Qplp { get; set; }
        public bool? Cplp { get; set; }
        public string LastFirst { get; set; }
        public string FirstLast { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Fax { get; set; }
        public string Url { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public bool? SalesMgmtAdmin { get; set; }
        public DateTime? RehireDate { get; set; }
        public string Login { get; set; }
        public string EncompassLogin { get; set; }
        public string ImpersonateUser { get; set; }
        public string ApplicationUrl { get; set; }
        public string ApplicationUrlShortcut { get; set; }
        public string Zillow { get; set; }
        public string SignatureEmail { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ImageUrl { get; set; }
        public bool? NotificationOptOut { get; set; }
        public string LicensingInfo { get; set; }
        public string CFirstName { get; set; }
        public string CLastName { get; set; }
        public string LoSubDomain { get; set; }
        public string LoWebsite { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public string MobileUrl { get; set; }
        public string Disclaimer { get; set; }

        public virtual Area Area { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual CostCenter CostCenter { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ProductionLevel ProductionLevel { get; set; }
        public virtual Branch ReportingBranch { get; set; }
        public virtual EmployeeType TypeNavigation { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<AssociatedBranch> AssociatedBranches { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<BusinessReview> BusinessReviews { get; set; }
        public virtual ICollection<ChecklistBranchChangeLog> ChecklistBranchChangeLogs { get; set; }
        public virtual ICollection<ChecklistBranchResponse> ChecklistBranchResponses { get; set; }
        public virtual ICollection<ChecklistChangeLog> ChecklistChangeLogCurrentUsers { get; set; }
        public virtual ICollection<ChecklistChangeLog> ChecklistChangeLogEmployees { get; set; }
        public virtual ICollection<ChecklistResponse> ChecklistResponseCheckedByUsers { get; set; }
        public virtual ICollection<ChecklistResponse> ChecklistResponseEmployees { get; set; }
        public virtual ICollection<Comment> CommentCreatedByNavigations { get; set; }
        public virtual ICollection<Comment> CommentCreatedForNavigations { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<EmployeeFile> EmployeeFiles { get; set; }
        public virtual ICollection<EncompassEmailOptOut> EncompassEmailOptOuts { get; set; }
        public virtual ICollection<HourlyRate> HourlyRates { get; set; }
        public virtual ICollection<IdeaInMotionComment> IdeaInMotionComments { get; set; }
        public virtual ICollection<IdeasInMotion> IdeasInMotions { get; set; }
        public virtual ICollection<Employee> InverseManager { get; set; }
        public virtual ICollection<ItchangeMatrix> ItchangeMatrices { get; set; }
        public virtual ICollection<OnBoardingBranchComment> OnBoardingBranchComments { get; set; }
        public virtual ICollection<ProductionPlan> ProductionPlans { get; set; }
        public virtual ICollection<RateDisclaimer> RateDisclaimers { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<StateDisclaimer> StateDisclaimers { get; set; }
        public virtual ICollection<Ticket> TicketEmployees { get; set; }
        public virtual ICollection<TicketHistory> TicketHistories { get; set; }
        public virtual ICollection<Ticket> TicketModifiedByNavigations { get; set; }
        public virtual ICollection<Ticket> TicketSubmittingFors { get; set; }
    }
}
