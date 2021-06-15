using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            ChecklistItemPermissions = new HashSet<ChecklistItemPermission>();
            Employees = new HashSet<Employee>();
            HireFormWorkflows = new HashSet<HireFormWorkflow>();
            HireForms = new HashSet<HireForm>();
            HourlyRates = new HashSet<HourlyRate>();
            TicketApprovers = new HashSet<TicketApprover>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Licensed { get; set; }
        public bool? Commissions { get; set; }
        public bool? ManagerPosition { get; set; }

        public virtual ICollection<ChecklistItemPermission> ChecklistItemPermissions { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<HireFormWorkflow> HireFormWorkflows { get; set; }
        public virtual ICollection<HireForm> HireForms { get; set; }
        public virtual ICollection<HourlyRate> HourlyRates { get; set; }
        public virtual ICollection<TicketApprover> TicketApprovers { get; set; }
    }
}
