using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class TicketFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public string MimeType { get; set; }
        public string Route { get; set; }
        public DateTime CreationDate { get; set; }
        public int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
