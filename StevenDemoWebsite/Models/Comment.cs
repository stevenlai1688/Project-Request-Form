using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? CreatedFor { get; set; }
        public string View { get; set; }

        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Employee CreatedForNavigation { get; set; }
    }
}
