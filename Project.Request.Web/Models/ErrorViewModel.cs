using System;

namespace Project.Models
{
    /// <summary>
    /// Error View Model for when webpage throws an error
    /// </summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
