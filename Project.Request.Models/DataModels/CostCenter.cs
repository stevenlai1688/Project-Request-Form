using System;

namespace Project.Request.Models.DataModels
{
    public class CostCenter
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Primary { get; set; }
    }
}