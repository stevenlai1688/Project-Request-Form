using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class IdeaInMotionComment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public int IdeaInMotionId { get; set; }
        public int CreatedBy { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual IdeasInMotion IdeaInMotion { get; set; }
    }
}
