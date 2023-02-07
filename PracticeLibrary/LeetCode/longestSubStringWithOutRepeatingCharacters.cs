using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary.LeetCode
{
    public class LongestSubStringWithOutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            int longestStringCount = 0;
            string string1 = String.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (string1.Contains(s[i]))
                {
                    if (length > longestStringCount)
                    {
                        longestStringCount = length;
                        length = 0;
                    }
                    length = 0;
                    string1 = string.Empty;
                }
                length++;

                if (length > longestStringCount)
                {
                    longestStringCount = length;
                }

                string1 = $"{string1}{s[i]}";
            }
            return longestStringCount;
        }
    }
}
