using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class EmployeeFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Route { get; set; }
        public DateTime CreationDate { get; set; }
        public int EmployeeId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
