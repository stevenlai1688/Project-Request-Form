using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project.Request.Services.Helpers
{
    public class HtmlTemplate : IHtmlTemplate
    {
        public string GetFullTemplate(string path, Dictionary<string, string> data)
        {
            if (string.IsNullOrEmpty(path) || data == null || data.Count == 0) return "";


            var templateString = GetTemplate(path);


            if (templateString == null || templateString.Length == 0) return "";


            var parsedTemplate = GetParsedTemplate(templateString, data);


            return parsedTemplate;
        }


        public string GetFullRawTemplate(Dictionary<string, string> data)
        {
            if (data == null || data.Count == 0) return "";


            var template = GetParsedTemplate(new StringBuilder(), data);


            return template;
        }


        private string GetParsedTemplate(StringBuilder template, Dictionary<string, string> data)
        {
            if (template == null || data == null) return "";


            if (template.Length == 0)
            {
                foreach (var item in data)
                    template.Append(item.Value);


                return template.ToString();
            }


            foreach (var item in data)
                template.Replace("{{" + item.Key + "}}", item.Value);


            return template.ToString();
        }


        private StringBuilder GetTemplate(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return null;


            try
            {
                var template = File.ReadAllText(path);


                return new StringBuilder(template);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}