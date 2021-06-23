using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CostCenterViewModel
    {
        [DisplayName("Id")] 
        public int Id { get; set; }
        [DisplayName("Code")] 
        public string Code { get; set; }
        [DisplayName("Description")] 
        public string Description { get; set; }
        [DisplayName("Active")]
        public bool Active { get; set; }
        [DisplayName("Modified By")] 
        public string ModifiedBy { get; set; }
        [DisplayName("Modified Date")] 
        public DateTime? ModifiedDate { get; set; }

        public string Capitalized
        {
            get
            {
                var capitalized = string.Empty;
                if (string.IsNullOrEmpty(Description)) return string.Empty;

                var arr = Description.Split(" ");
                if (arr.Length == 1)
                {
                    capitalized = arr[0].Substring(0, 1).ToUpper() + arr[0].Substring(1).ToLower();
                }
                else {
                    foreach (string item in arr)
                    {
                        string toBeCapitalized = item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower();
                        capitalized += string.IsNullOrEmpty(capitalized) ? toBeCapitalized : " " + toBeCapitalized;
                    }

                }
                // 'It' is an exception, it should be 'IT'
                return capitalized == "It" ? "IT" : capitalized;
            }
        }
    }
}
