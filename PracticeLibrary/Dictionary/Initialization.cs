using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary.Dictionary
{
    public static class Initialization
    {

        private static Dictionary<string, DateTime> HolidayDatesForHourly = new Dictionary<string, DateTime>()
        {

            {"NewYearsDay", new DateTime(2022, 01, 01)},
            {"MemorialDay", new DateTime(2022, 05, 30)},
            {"FourthOfJuly", new DateTime(2022, 07, 04)},
            {"LaborDay", new DateTime(2022, 09, 05)},
            {"Thanksgiving", new DateTime(2022, 11, 24)},
            {"Christmas", new DateTime(2022, 12, 26)}
        };

        private static Dictionary<string, DateTime> HolidayDates = new Dictionary<string, DateTime>()
        {
            {"NewYearsDay", new DateTime(2022, 01, 01)},
            {"MemorialDay", new DateTime(2022, 05, 30)},
            {"FourthOfJuly", new DateTime(2022, 07, 04)},
            {"LaborDay", new DateTime(2022, 09, 05)},
            {"Thanksgiving", new DateTime(2022, 11, 24)},
            {"Christmas", new DateTime(2022, 12, 25)}
        };
        public static void AssignmentTest1()
        {
            if (true)
            {
                HolidayDates = new Dictionary<string, DateTime>
                {

                    { "NewYearsDay", new DateTime(2022, 01, 01)},
                    { "MemorialDay", new DateTime(2022, 05, 30)},
                    { "FourthOfJuly", new DateTime(2022, 07, 04)},
                    { "LaborDay", new DateTime(2022, 09, 05)},
                    { "Thanksgiving", new DateTime(2022, 11, 24)},
                    { "Christmas", new DateTime(2022, 12, 26)}
                };
            }
        }
        
        public static void AssignmentTest2()
        {
            HolidayDates = HolidayDatesForHourly;
        }
    }
}
