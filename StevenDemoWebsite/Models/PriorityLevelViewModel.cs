using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace StevenDemoWebsite.Models
{
        public class PriorityLevelViewModel
        {
            public List<StevenDemoTable> StevenTables { get; set; }
            public SelectList Priority { get; set; }
            public string SearchPriority { get; set; }
            public string SearchName { get; set; }
        }
    
}
