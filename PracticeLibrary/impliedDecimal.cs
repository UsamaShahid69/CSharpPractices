using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary
{
    public static class ImpliedDecimal
    {
        public static void RemoveDecimalPoint()
        {
            Console.WriteLine(Convert.ToString(12).ImpliedString().AddSpace(7));
            
        }
        private static string ImpliedString(this string str)
        {
            if (str == null) return str;
            if (!str.Contains('.'))
            {
                return str.PadRight(str.Length + 2, '0');
            }
            var splitString = str.Split('.');
            if (splitString[0] == "0")
            {
                return splitString[1].PadRight(2, '0');
            }
            return string.Concat(splitString[0], splitString[1].PadRight(2, '0'));
        }

        private static string AddSpace(this string str, int totalWidth)
        {
            if (str == null) return str;

            return str.PadRight(totalWidth, ' ');
        }
    }
}
