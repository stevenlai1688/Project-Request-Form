using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ChecklistItemPermission
    {
        public int Id { get; set; }
        public int? ChecklistItemId { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ChecklistItem ChecklistItem { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
    }
}
