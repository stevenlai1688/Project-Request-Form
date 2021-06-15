using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Answer
    {
        public Answer()
        {
            Responses = new HashSet<Response>();
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public bool Correct { get; set; }
        public int QuestionId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
    }
}
