using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class ItchangeMatrixFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Route { get; set; }
        public DateTime CreationDate { get; set; }
        public int ItchangeMatrixId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ItchangeMatrix ItchangeMatrix { get; set; }
    }
}
