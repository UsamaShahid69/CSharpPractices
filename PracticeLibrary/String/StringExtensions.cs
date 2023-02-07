using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary
{
    public static class StringExtensions
    {
        /// <summary>
        /// Ensures the index is within the bounds of the array before doing substring
        /// If the index is larger than the string length, the entire string is returned
        /// </summary>
        /// <param name="original">The original string</param>
        /// <param name="max">The number of characters to take from the original string</param>
        /// <returns></returns>
        public static string SafeSubstring(this string original, int max)
        {
            if (max < 0) return original;

            return original?.Substring(0, Math.Min(original.Length, max));
        }
        /// <summary>
        /// Ensures the index is within the bounds of the array before doing substring
        /// If the strart index plus length of substring is larger or equal than the string length, the empty string is returned
        /// </summary>
        /// <param name="original"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string SafeSubstring(this string original, int startIndex, int length)
        {
            if (string.IsNullOrEmpty(original) || startIndex < 0 || length < 0 || startIndex + length >= original.Length) return string.Empty;
            var retStr = original.Substring(startIndex, length);

            return retStr;
        }
    }
}
