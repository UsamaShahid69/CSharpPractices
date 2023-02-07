using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary;

public static class DateTimeTest
{
    public static void Test1()
    {
        int startHour = 7;
        int startMinutes = 0;
        int endHour = 15;
        int endMinutes = 30;
        DateTime date = DateTime.Now;

        DateTime dt = new DateTime(2022, 8, 22, startHour, startMinutes, 0, DateTimeKind.Local).ToUniversalTime();
        Console.WriteLine(dt);

    }

    public static void Test2()
    {
        var date = DateTime.Today.AddDays(-1).ToShortDateString().Replace('/', '-');
    } 
    
    public static void Test3()
    {
        var workDays = new List<DayOfWeek>() { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
        var dayNumber = DateTime.Now.DayOfWeek;
        var dayToStartFrom = workDays.FindIndex(day => day == dayNumber);
        workDays.RemoveRange(0, (dayToStartFrom + 1));
        Console.WriteLine(workDays.ToString());
    }
    
    public static void Test4()
    {
        var workDays = new List<DayOfWeek>() { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
        var dayName = DateTime.Now.DayOfWeek;
        for (int i = 0; i < workDays.Count; i++)
        {
            if (workDays[i] == dayName)
            {
                workDays.RemoveRange(0, i + 1);
                break;
            }
        }
        Console.WriteLine(workDays.ToString());
    }


}
