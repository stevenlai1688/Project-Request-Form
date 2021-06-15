using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ChecklistItem
    {
        public ChecklistItem()
        {
            ChecklistBranchChangeLogs = new HashSet<ChecklistBranchChangeLog>();
            ChecklistBranchResponses = new HashSet<ChecklistBranchResponse>();
            ChecklistChangeLogs = new HashSet<ChecklistChangeLog>();
            ChecklistItemPermissions = new HashSet<ChecklistItemPermission>();
            ChecklistResponses = new HashSet<ChecklistResponse>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Item { get; set; }
        public string Details { get; set; }
        public int SortOrder { get; set; }
        public int? DueByDays { get; set; }
        public bool? Active { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ChecklistCategory Category { get; set; }
        public virtual ICollection<ChecklistBranchChangeLog> ChecklistBranchChangeLogs { get; set; }
        public virtual ICollection<ChecklistBranchResponse> ChecklistBranchResponses { get; set; }
        public virtual ICollection<ChecklistChangeLog> ChecklistChangeLogs { get; set; }
        public virtual ICollection<ChecklistItemPermission> ChecklistItemPermissions { get; set; }
        public virtual ICollection<ChecklistResponse> ChecklistResponses { get; set; }
    }
}
