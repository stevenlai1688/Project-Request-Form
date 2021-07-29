using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project.Request.Models.DataModels
{
    public class PriorityLevel
    {
        public List<ProjectRequest> ProjectRequestTables { get; set; }
        public SelectList Priority { get; set; }
        public string SearchPriority { get; set; }
        public string SearchName { get; set; }
    }
}