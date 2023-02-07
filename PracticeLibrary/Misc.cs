using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary
{
    public class Misc
    {
        public static void DateTimeKindResult()
        {
            DateTime date = DateTime.Now;
            var startHour = 11;
            var startMinutes = 0;
            var endHour = 19;
            var endMinutes = 30;

            var kindDate = new DateTime(date.Year, date.Month, date.Day, startHour, startMinutes, 0, DateTimeKind.Local);
            Console.WriteLine(kindDate);
        }

    }
}
