using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class IdeaInMotionFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Route { get; set; }
        public DateTime CreationDate { get; set; }
        public int IdeaInMotionId { get; set; }

        public virtual IdeasInMotion IdeaInMotion { get; set; }
    }
}
