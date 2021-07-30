using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Project.Request.Web.Models
{
    /// <summary>
    ///     Project Request View Model is the main ViewModel used to format and display all the ProjectRequest Model methods
    /// </summary>
    public class ProjectRequestViewModel
    {
        public int Id { get; set; }

        [DisplayName("Reason for Changes")] [Required] public string RequestReason { get; set; }

        [Required]
        [DisplayName("Project Owner Name")]
        [StringLength(50)]
        public string RequestorName { get; set; }

        [DisplayName("Requested Completion Date")]
        [DataType(DataType.Date)]
        public DateTime DesiredCompletionDate { get; set; }

        [DisplayName("Priority")] [Required] public string PriorityLevel { get; set; }

        [DisplayName("Description of Changes")]
        [Required]
        public string RequestDescription { get; set; }

        [DisplayName("Changes Requested")] [Required]
        public string RequestChanges { get; set; }
        [DisplayName("Effect on Organization")]
        public string RequestEffectsOnOrganization { get; set; }


        [DisplayName("Business Justifications")]
        [Required]
        public List<string> BusinessJustification { get; set; }

        [DisplayName("Departments")] public string Departments { get; set; }

        [DisplayName("Departments")]
        [Required]
        public IEnumerable<string> DepartmentsId { get; set; }

        public bool CheckedItems { get; set; }

        public string Items { get; set; }

        [StringLength(50)]
        [DisplayName("Project Name")]
        [Required]
        public string ProjectName { get; set; }
    }
}