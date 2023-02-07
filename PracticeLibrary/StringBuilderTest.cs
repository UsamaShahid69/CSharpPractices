using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary
{
    public class StringBuilderTest
    {
        public static void M()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("a");
            sb.AppendLine("b");
            sb.AppendLine("c");
            sb.AppendLine("d");
            Console.WriteLine(sb.ToString());
        }
        
    }
}
