using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class BusinessReviewReport
    {
        public Guid Id { get; set; }
        public string GeneratedBy { get; set; }
        public string GeneratedFor { get; set; }
        public string DateGenerated { get; set; }
        public string CurrentStatus { get; set; }
        public string StatusDate { get; set; }
        public string DateRange { get; set; }
    }
}
