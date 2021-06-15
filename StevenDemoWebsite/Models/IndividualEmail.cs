using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class IndividualEmail
    {
        public int Id { get; set; }
        public int EmailNumber { get; set; }
        public string Email { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
