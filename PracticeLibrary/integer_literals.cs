using System.Numerics;

namespace PracticeLibrary
{
    public class IntegerLiterals
    {
        public static void Hex()
        {
            string int16 = "NoBitches";
            
            Console.WriteLine();



        }

    }
    public class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            string string1 = string.Empty;
            int maxLengthSofar = 0;
            int counter = 0;
            Console.WriteLine(s.Length);
            foreach (var ch in s)
            {
                if (string1.Contains(ch))
                {
                    string1 = string.Empty;
                    maxLengthSofar = Math.Max(counter, maxLengthSofar);
                    counter = 0;
                }
                counter++;
                string1 = string1 + ch;
            }
            return maxLengthSofar;
        }
    }
}
