using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class TicketApprover
    {
        public TicketApprover()
        {
            TicketApproverStatuses = new HashSet<TicketApproverStatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int ApprovalOrder { get; set; }
        public int EmployeeTypeId { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
        public virtual ICollection<TicketApproverStatus> TicketApproverStatuses { get; set; }
    }
}
