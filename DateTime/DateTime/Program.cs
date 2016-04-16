using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZoneInfo tzByID = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tzByID));
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime dt = Convert.ToDateTime("10-12-2013 04:05:20");
            Console.WriteLine(dt);
            // Demonstrate ToLocalTime and ToUniversalTime.
            Console.WriteLine(zone.StandardName);
            DateTime local = zone.ToLocalTime(DateTime.Now);
            DateTime universal = zone.ToUniversalTime(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(local);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(universal);
           // TimeZoneInfo tzByID = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            Console.WriteLine(tzByID.GetUtcOffset(dt));
            TimeSpan offset = zone.GetUtcOffset(DateTime.Now);
           
            Console.WriteLine(offset);
            Console.ReadLine();

        }
    }
}
