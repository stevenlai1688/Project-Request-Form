using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class OpsLogsColumn
    {
        public int Id { get; set; }
        public string Report { get; set; }
        public string ColumnName { get; set; }
        public string DisplayName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
