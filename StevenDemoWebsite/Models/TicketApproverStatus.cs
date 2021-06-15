using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class TicketApproverStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string Type { get; set; }
        public int TicketApproverId { get; set; }
        public int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual TicketApprover TicketApprover { get; set; }
    }
}
