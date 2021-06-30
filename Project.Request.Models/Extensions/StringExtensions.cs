using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Request.Models.Extensions
{
    public static class StringExtensions
    {
        public static string Truncate(this string str, int maxLength)
        {
            // if this string is not empty, return this string, otherwise, check the string length and if it is greater than max length, 
            // truncate it 
            return string.IsNullOrEmpty(str) ? str :
                str.Length < maxLength ? str : $"{str.Substring(0, Math.Min(str.Length, maxLength - 3))}...";
        }

        public static void Each<T>(this IEnumerable<T> ie, Action<T, int> action)
        {
            var i = 0;
            foreach (var e in ie) action(e, i++);
        }
    }
}
