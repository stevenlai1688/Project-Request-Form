using System.Collections.Generic;

namespace Project.Request.Services.Helpers
{
    public interface IHtmlTemplate
    {
        string GetFullTemplate(string path, Dictionary<string, string> data);
        string GetFullRawTemplate(Dictionary<string, string> data);
    }
}