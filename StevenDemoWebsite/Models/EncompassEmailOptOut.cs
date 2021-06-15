using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class EncompassEmailOptOut
    {
        public int Id { get; set; }
        public int EncompassEmailDefinitionId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual EncompassEmailDefinition EncompassEmailDefinition { get; set; }
    }
}
