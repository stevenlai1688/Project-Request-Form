using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class TicketReinbursementFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public string Route { get; set; }
        public DateTime CreationDate { get; set; }
        public int TicketReinbursementId { get; set; }

        public virtual TicketReinbursement TicketReinbursement { get; set; }
    }
}
