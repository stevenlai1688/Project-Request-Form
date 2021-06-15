using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class MilestoneEmailTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? EmailNumber { get; set; }
    }
}
