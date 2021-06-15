using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class CombinedBranchView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string Division { get; set; }
        public string BranchManagerUserName { get; set; }
        public string RegionManagerUserName { get; set; }
        public string DivisionManagerUserName { get; set; }
        public string AreaName { get; set; }
        public string AreaManagerName { get; set; }
        public string AreaManagerUserName { get; set; }
        public string BranchManagerEmail { get; set; }
        public string RegionManagerEmail { get; set; }
        public string DivisionManagerEmail { get; set; }
        public string AreaManagerEmail { get; set; }
    }
}
