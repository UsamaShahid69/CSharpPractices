using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary.List
{
    public static class ListTests
    {
        public static void Index()
        {
            List<string> field3Value = new List<string> { "FT37.5", "FT40" };
            int endHour = 16; // for 8 hours grant
            int endMinute = 0;
            // if Field 3 is equal to FT37.5, Assign 7.5 hours grant
            if (field3Value[0].Equals("FT37.5", StringComparison.InvariantCultureIgnoreCase))
            {
                endHour = 15;
                endMinute = 30;
            }
        } 
        
        public static void Any()
        {
            List<string> field3Value = new List<string> { "FT37.5", "FT40" };
            int endHour = 16; // for 8 hours grant
            int endMinute = 0;
            // if Field 3 is equal to FT37.5, Assign 7.5 hours grant
            if (!field3Value.Any(x => x.Equals("FT40", StringComparison.InvariantCultureIgnoreCase)))
            {
                endHour = 15;
                endMinute = 30;
            }
        }
    }
}
