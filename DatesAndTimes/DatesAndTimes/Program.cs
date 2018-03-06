using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 14 https://channel9.msdn.com/series/C-Fundamentals-for-Absolute-Beginners/14

            DateTime dtValue = DateTime.Now;
            Console.WriteLine(dtValue.ToString() + "\n"); // Display Date and Time

            DateTime dateValue = DateTime.Now;
            Console.WriteLine(dateValue.ToShortDateString() + "\n"); // Display Date only

            DateTime stValue = DateTime.Now;
            Console.WriteLine(stValue.ToShortTimeString() + "\n");  // Display Time, no seconds

            DateTime longdValue = DateTime.Now;
            Console.WriteLine(longdValue.ToLongDateString() + "\n"); // display date "Tuesday, 6 March 2018" in that format

            DateTime longtValue = DateTime.Now;
            Console.WriteLine(longtValue.ToLongTimeString() + "\n"); // Display time with seconds

            DateTime dayValue = DateTime.Now;
            Console.WriteLine(dayValue.AddDays(3).ToLongDateString() + "\n"); // Adds 3 days to the current date

            DateTime hourValue = DateTime.Now;
            Console.WriteLine(hourValue.AddHours(4).ToLongTimeString() + "\n"); // Adds 4 hours to the current time

            DateTime daysValue = DateTime.Now;
            Console.WriteLine(daysValue.AddDays(-3).ToShortDateString() + "\n"); // Subtracts 3 days from current date

            DateTime monthValue = DateTime.Now;
            Console.WriteLine(monthValue.Month.ToString() + "\n"); // Displays what the current month is with just a number. So if the month is March, it will display 3, being the third month.

            DateTime myBirthday = new DateTime(1979, 11, 30);
            Console.WriteLine(myBirthday.ToShortDateString() + "\n");

            DateTime countBirthday = DateTime.Parse("30/11/1979"); // Enter your date of birth here for Parsing
            TimeSpan countAge = DateTime.Now.Subtract(countBirthday); // Timespan object
            Console.WriteLine(countAge.TotalDays); // Counts the number of days since you were born

            // Consult the MSDN, the .NET framework has a lot of date & time features already built into it

            Console.ReadLine();
        }
    }
}
