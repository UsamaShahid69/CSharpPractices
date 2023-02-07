using Castle.MicroKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary.LoopTesting
{
    public sealed record class ForeachLoop
    {
        public static void NullTest(int a)
        {
           // Arguments.NoNull(a, nameof(a));
            List<string> strings = new List<string>();
            strings = null;
            foreach(var str in strings)
            {
                Console.WriteLine("lsjl");
            }
        }
    }
}
