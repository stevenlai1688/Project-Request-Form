using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class HireFormFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Route { get; set; }
        public DateTime CreationDate { get; set; }
        public int FormId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual HireFormWorkflow Form { get; set; }
    }
}
