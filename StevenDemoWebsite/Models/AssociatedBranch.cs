using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class AssociatedBranch
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
