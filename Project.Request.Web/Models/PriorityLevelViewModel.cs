using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project.Request.Web.Models
{
    /// <summary>
    ///     Priority Level View Model is passed to ProjectRequest-Index View in order to order the data based on PriorityLevel
    ///     This class uses Project Request View Model to build different ViewModel that each contains different PriorityLevel
    ///     to be passed through the Index View, which the user selects.
    /// </summary>
    public class PriorityLevelViewModel
    {
        public List<ProjectRequestViewModel> ProjectRequestTables { get; set; }

        public SelectList Priority { get; set; }

        public string SearchPriority { get; set; }

        public string SearchName { get; set; }
    }
}