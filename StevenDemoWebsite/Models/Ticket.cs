using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            TicketApproverStatuses = new HashSet<TicketApproverStatus>();
            TicketFiles = new HashSet<TicketFile>();
            TicketHistories = new HashSet<TicketHistory>();
            TicketReinbursements = new HashSet<TicketReinbursement>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int? SubmittingForId { get; set; }
        public string Activity { get; set; }
        public string Title { get; set; }
        public string Vendor { get; set; }
        public double? CostAmount { get; set; }
        public string PaymentType { get; set; }
        public string ChargedTo { get; set; }
        public string ChargeToSpecified { get; set; }
        public double? MarketingPercentage { get; set; }
        public bool? PayingActivity { get; set; }
        public bool? Recurring { get; set; }
        public string Frequency { get; set; }
        public string Description { get; set; }
        public bool? TermsAgreed { get; set; }
        public bool? AttachedContract { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateExpired { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Employee ModifiedByNavigation { get; set; }
        public virtual Employee SubmittingFor { get; set; }
        public virtual ICollection<TicketApproverStatus> TicketApproverStatuses { get; set; }
        public virtual ICollection<TicketFile> TicketFiles { get; set; }
        public virtual ICollection<TicketHistory> TicketHistories { get; set; }
        public virtual ICollection<TicketReinbursement> TicketReinbursements { get; set; }
    }
}
