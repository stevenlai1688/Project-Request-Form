using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ChecklistChangeLog
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public int ChecklistItemId { get; set; }
        public int EmployeeId { get; set; }
        public bool? EmailSent { get; set; }
        public int CurrentUserId { get; set; }

        public virtual ChecklistItem ChecklistItem { get; set; }
        public virtual Employee CurrentUser { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
