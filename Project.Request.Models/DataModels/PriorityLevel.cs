
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Project.Models
{
    public class PriorityLevel
        {
            public List<StevenDemoTable> StevenTables { get; set; }
            public SelectList Priority { get; set; }
            public string SearchPriority { get; set; }
            public string SearchName { get; set; }
        }
    
}
