using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtensions
    {
        public static int CountWords(this string text, bool trimBlank)
        {
            if (trimBlank)
            {
                text = text.Trim();
            }
             
            string[] parts = text.Split(' ');
            return parts.Count(x => !string.IsNullOrWhiteSpace(x));
        }
    }
}
