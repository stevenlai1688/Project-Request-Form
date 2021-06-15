using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ChecklistForm
    {
        public ChecklistForm()
        {
            ChecklistCategories = new HashSet<ChecklistCategory>();
        }

        public int Id { get; set; }
        public string Form { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ChecklistCategory> ChecklistCategories { get; set; }
    }
}
