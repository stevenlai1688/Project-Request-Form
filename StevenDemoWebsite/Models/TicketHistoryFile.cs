using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class TicketHistoryFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public string Route { get; set; }
        public DateTime CreationDate { get; set; }
        public int TicketHistoryId { get; set; }

        public virtual TicketHistory TicketHistory { get; set; }
    }
}
