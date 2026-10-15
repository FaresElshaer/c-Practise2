using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{
    public static class StringExtensions
    {
        public static string RemoveWiteSpaces(this string str)
        {
            return str.Replace(" ", "");
        }
        public static string Reverse(this string value)
        {
           var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
