using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class BusinessReviewFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Route { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid BusinessReviewId { get; set; }
        public int BusinessReviewVersion { get; set; }

        public virtual BusinessReview BusinessReview { get; set; }
    }
}
