using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class TicketReinbursement
    {
        public TicketReinbursement()
        {
            TicketReinbursementFiles = new HashSet<TicketReinbursementFile>();
        }

        public int Id { get; set; }
        public string RequestType { get; set; }
        public double ActualCost { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool RecurringCharge { get; set; }
        public string ChargeFrequency { get; set; }
        public string InvoiceDeliveryMethod { get; set; }
        public string InvoiceDeliveryMethodSpecified { get; set; }
        public int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual ICollection<TicketReinbursementFile> TicketReinbursementFiles { get; set; }
    }
}
