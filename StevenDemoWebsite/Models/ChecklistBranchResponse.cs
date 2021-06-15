using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ChecklistBranchResponse
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int CheckListItemId { get; set; }
        public int CheckedByUserId { get; set; }
        public DateTime? CheckedDateTime { get; set; }
        public bool? Checked { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual ChecklistItem CheckListItem { get; set; }
        public virtual Employee CheckedByUser { get; set; }
    }
}
