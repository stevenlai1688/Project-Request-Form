using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class IdeasInMotion
    {
        public IdeasInMotion()
        {
            IdeaInMotionComments = new HashSet<IdeaInMotionComment>();
            IdeaInMotionFiles = new HashSet<IdeaInMotionFile>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Summary { get; set; }
        public int? IdeaOwnerId { get; set; }
        public string Idea { get; set; }
        public string InitialResponse { get; set; }
        public int? PrimaryDepartmentId { get; set; }
        public string Departments { get; set; }
        public string Result { get; set; }
        public string FinalResponse { get; set; }
        public bool? Viable { get; set; }
        public string ResourcesNeccesary { get; set; }
        public string TimeToComplete { get; set; }
        public string IdeaPurpose { get; set; }
        public string HardCost { get; set; }
        public string Iimstatus { get; set; }
        public string Category { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Employee IdeaOwner { get; set; }
        public virtual CostCenter PrimaryDepartment { get; set; }
        public virtual ICollection<IdeaInMotionComment> IdeaInMotionComments { get; set; }
        public virtual ICollection<IdeaInMotionFile> IdeaInMotionFiles { get; set; }
    }
}
