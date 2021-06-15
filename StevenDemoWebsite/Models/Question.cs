using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            Responses = new HashSet<Response>();
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public string ResponseType { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
    }
}
