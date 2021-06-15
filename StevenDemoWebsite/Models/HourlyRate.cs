using System;
using System.Collections.Generic;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class HourlyRate
    {
        public int Id { get; set; }
        public string PayType { get; set; }
        public double Rate { get; set; }
        public string State { get; set; }
        public int EmployeeTypeId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Employee ModifiedByNavigation { get; set; }
    }
}
