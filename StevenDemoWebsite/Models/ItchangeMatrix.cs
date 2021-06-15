using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ItchangeMatrix
    {
        public ItchangeMatrix()
        {
            ItchangeMatricesFile = new HashSet<ItchangeMatrixFile>();
        }

        public int Id { get; set; }
        public string ChangeActivity { get; set; }
        public string ReasonForChange { get; set; }
        public string Status { get; set; }
        public string Discipline { get; set; }
        public int Likelihood { get; set; }
        public int Severity { get; set; }
        public int OverallRiskLevel { get; set; }
        public string Itcabrequired { get; set; }
        public string CommunicationRequired { get; set; }
        public string DocumentedProcedure { get; set; }
        public string LogRequired { get; set; }
        public string RollbackPlan { get; set; }
        public int? ApprovedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ChangeNeededBy { get; set; }
        public string Description { get; set; }
        public string OutageDuration { get; set; }

        public virtual Employee ApprovedByNavigation { get; set; }
        public virtual ICollection<ItchangeMatrixFile> ItchangeMatricesFile { get; set; }
    }
}
