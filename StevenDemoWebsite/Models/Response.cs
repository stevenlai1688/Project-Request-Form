using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Response
    {
        public int Id { get; set; }
        public DateTime ResponseDate { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual Question Question { get; set; }
    }
}
