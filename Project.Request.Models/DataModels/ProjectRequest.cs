
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

#nullable disable

namespace Project.Models
{
    public partial class ProjectRequest
    {

        public int Id { get; set; }

        public string RequestReason { get; set; }

        public string RequestorName { get; set; }

        public DateTime DesiredCompletionDate { get; set; }

        public string PriorityLevel { get; set; }

        public string RequestDescription { get; set; }

        public string RequestChanges { get; set; }

        public string RequestEffectsOnOrganization { get; set; }

        public string EstimateTimeFrame { get; set; }
        public string BusinessJustification { get; set; }
        public string Departments { get; set; }
        public string ProjectName { get; set; }

    }
}

