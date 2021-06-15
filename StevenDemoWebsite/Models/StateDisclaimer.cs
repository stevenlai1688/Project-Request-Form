using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class StateDisclaimer
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Disclaimer { get; set; }
        public DateTime CreationDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Employee ModifiedByNavigation { get; set; }
    }
}
