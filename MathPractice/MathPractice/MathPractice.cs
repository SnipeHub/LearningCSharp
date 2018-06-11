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
            string monString, tueString, wedString, thurString, friString;
            double adminMon, adminTue, adminWed, adminThur, admiFri, totalMon, totalTue, totalWed, totalThu, totalFri;

            Console.WriteLine("Please enter to total time for Monday(Do not include admin): ");
            monString = Console.ReadLine();
            Mon = double.Parse(monString);

            Console.WriteLine("Please enter the total time for Tuesday: ");
            tueString = Console.ReadLine();
            Tue = double.Parse(tueString);

            //Wed = 1.4 + 3.3;
            //double adminWed = 7.5 - Wed;
            //Console.WriteLine("Wednesday is: " + Wed + " - " + "Admin is: " + adminWed + "\n");

            //Thu = 1.5 + 3.4;
            //double adminThur = 7.5 - Thu;
            //Console.WriteLine("Thursday 01.03.2018 is: " + Thu + " - " + "Admin is: " + adminThur + "\n");

            //Fri = 1.4 + 1.4;
            //double adminFri = 7.5 - Fri;
            //Console.WriteLine("Friday 23.02 is: " + Fri + " - " + "Admin is: " + adminFri + "\n");     

            totalMon = 7.5 - Mon; // do calculations here
            totalTue = 7.5 - Tue;
            //totalWed = 7.5 - Wed;
            //totalThu = 7.5 - Thu;
            //totalFri = 7.5 - Fri;

            Console.WriteLine("Monday field hrs: " + Mon + " / " + "Your admin is: " + totalMon + "\n");
            Console.WriteLine("Tuesday field hrs: " + Tue + " / " + "Your admin is: " + totalTue + "\n");
            //Console.WriteLine("Tuesday field hrs: " + Wed + " / " + "Your admin is: " + totalWed + "\n");
            //Console.WriteLine("Tuesday field hrs: " + Thu + " / " + "Your admin is: " + totalThu + "\n");
            //Console.WriteLine("Tuesday field hrs: " + Fri + " / " + "Your admin is: " + totalFri + "\n");

            /*
            Next iteration is to do this as a windows program with input fields. This is my first ever C# program to be made by moi.
            For now this is pretty much done as is, once I learn how to have user input, it will be added.
            */
        }
    }
}
