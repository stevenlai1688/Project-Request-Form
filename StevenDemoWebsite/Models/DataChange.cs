using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class DataChange
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NewFullName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Licence { get; set; }
        public string BranchName { get; set; }
        public string BranchFullAddress { get; set; }
        public string ProcessorName { get; set; }
        public string ProcessorPhone { get; set; }
        public string ProcessorEmail { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
