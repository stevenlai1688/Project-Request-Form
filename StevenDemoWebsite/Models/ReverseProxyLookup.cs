using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ReverseProxyLookup
    {
        public int Id { get; set; }
        public string StartsWithSegments { get; set; }
        public string TargetUri { get; set; }
    }
}
