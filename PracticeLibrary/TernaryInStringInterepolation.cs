using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary
{
    public static class TernaryInStringInterepolation
    {
        public static void Test(string str = null, bool bo = true)
        {
            string formOrDoc = bo ? "Form" : "Document";
            Console.WriteLine($"{(!string.IsNullOrEmpty(str) ? formOrDoc + $" with name {str} uploaded successfully." : formOrDoc + " uploaded successfully.")}");
        }
        
        public static void Test2(bool bo = true)
        {
            string blobName = (bo ? "forms/" : "docs/") + Guid.NewGuid().ToString();
            Console.WriteLine(blobName);
        }
    }
}
