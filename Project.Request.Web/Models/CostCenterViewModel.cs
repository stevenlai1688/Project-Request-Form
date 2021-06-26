using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    /// <summary>
    /// Cost Center View Model which formats the Cost Center model to be displayed
    /// </summary>
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
        /// <summary>
        /// a helper method that takes the string recieved from Description and Capitalize the first letter of each word
        /// </summary>
        public string Capitalized
        {
            get
            {
                // making sure that if the string recieved is empty, then return an empty string
                var capitalized = string.Empty;
                if (string.IsNullOrEmpty(Description)) return string.Empty;
                // otherwise, split the description into different words and put it in an array of strings
                var arr = Description.Split(" ");
                // another statement to catch the case where there is only one word in the array
                if (arr.Length == 1)
                {
                    capitalized = arr[0].Substring(0, 1).ToUpper() + arr[0].Substring(1).ToLower();
                }
                else {
                    // otherwise, loop through the strings in the string array
                    foreach (string item in arr)
                    {
                        // capitalize each word and then concatenate each iteration to the final version of the description
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
