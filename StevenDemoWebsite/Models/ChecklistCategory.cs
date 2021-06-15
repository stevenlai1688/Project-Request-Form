using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ChecklistCategory
    {
        public ChecklistCategory()
        {
            ChecklistItems = new HashSet<ChecklistItem>();
        }

        public int Id { get; set; }
        public string Category { get; set; }
        public int SortOrder { get; set; }
        public int FormId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ChecklistForm Form { get; set; }
        public virtual ICollection<ChecklistItem> ChecklistItems { get; set; }
    }
}
