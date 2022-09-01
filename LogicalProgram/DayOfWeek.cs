using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class DayOfWeek
    {
        int day, month, year;
        public void Days()
        {
            Console.WriteLine("Please Enter the Date");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Year");
            year = Convert.ToInt32(Console.ReadLine());
            int x, days, months, years;
            years = year - (14 - month) / 12;
            x = years + years / 4 - years / 100 + years / 400;
            months = month + 12 * ((14 - month) / 12) - 2;
            days = (day + x + 31 * months / 12) % 7;
            Console.WriteLine("Calculate the day as per: \n Monday = 1 \n Tuesday = 2 \n Wednesday = 3 \n Thursday = 4 \n Friday = 5 \n Saturday = 6 \n Sunday = 0");
            Console.WriteLine(days + " is the day of the week that date falls on " + day + "/" + month + "/" + year + ".");
        }
    }
}
