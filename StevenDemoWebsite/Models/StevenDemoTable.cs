using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class StevenDemoTable
    {
        public int Id { get; set; }
        [DisplayName("Reason")]
        public string RequestReason { get; set; }
        [Required]
        [DisplayName("Name")]
        public string RequestorName { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime DesiredCompletionDate { get; set; }
        
        [DisplayName("Priority")]
        [Required]
        public string PriorityLevel{ get; set;}

        [DisplayName("Description")]
        public string RequestDescription { get; set; }

        [DisplayName("Changes")]
        public string RequestChanges { get; set; }
    }
}
