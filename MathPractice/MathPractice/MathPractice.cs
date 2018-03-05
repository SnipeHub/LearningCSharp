using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPractice
{
    class Timesheet
    {
        static void Main(string[] args)
        {
            /* 
            A different way of writing it, not sure if its better or not!! 

            Scrap that, apperently my original way is better.
            */

            /*
            double adminOne;
            double dayTotalOne;

            dayTotalOne = 0.5 + 3.0;
            adminOne = 7.5 - dayTotalOne;
            Console.WriteLine("Monday Total: " + dayTotalOne + " - " + "Admin: " + adminOne);
            */

            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + now + "\n");

            double Mon, Tue, Wed, Thu, Fri, Sat, Sun; // Fixing up further by declaring all variables up here and shortening it

            Mon = 0.9 + 1.8; // Edit these values for each day
            double adminMon = 7.5 - Mon;
            Console.WriteLine("Monday is: " + Mon + " - "  + "Admin is: " + adminMon + "\n");

            Tue = 2.0 + 3.4;
            double adminTue = 7.5 - Tue;
            Console.WriteLine("Tuesday is: " + Tue + " - " + "Admin is: " + adminTue + "\n");

            Wed = 1.4 + 3.3;
            double adminWed = 7.5 - Wed;
            Console.WriteLine("Wednesday is: " + Wed + " - " + "Admin is: " + adminWed + "\n");

            Thu = 1.2 + 3.8;
            double adminThur = 7.5 - Thu;
            Console.WriteLine("Thursday 01.03.2018 is: " + Thu + " - " + "Admin is: " + adminThur + "\n");
            /*
            Fri = 1.0 + 2.8;
            double adminFri = 7.5 - Fri;
            Console.WriteLine("Friday 23.02 is: " + Fri + " - " + "Admin is: " + adminFri + "\n");                 
            */
            Console.ReadLine();

            /*
            Next iteration is to do this as a windows program with input fields. This is my first ever C# program to be made by moi.
            For now this is pretty much done as is, once I learn how to have user input, it will be added.
            */
        }
    }
}
