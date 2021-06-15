using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class EncompassEmailDefinition
    {
        public EncompassEmailDefinition()
        {
            EncompassEmailOptOuts = new HashSet<EncompassEmailOptOut>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Json { get; set; }
        public string QueryCriteria { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Template { get; set; }
        public string SentFieldId { get; set; }
        public string FromAddresses { get; set; }
        public string ToAddresses { get; set; }
        public string CcAddresses { get; set; }
        public string BccAddresses { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }
        public bool? TestMode { get; set; }

        public virtual ICollection<EncompassEmailOptOut> EncompassEmailOptOuts { get; set; }
    }
}
