using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class TicketHistory
    {
        public TicketHistory()
        {
            TicketHistoryFiles = new HashSet<TicketHistoryFile>();
        }

        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public int EmployeeId { get; set; }
        public int TicketId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual ICollection<TicketHistoryFile> TicketHistoryFiles { get; set; }
    }
}
