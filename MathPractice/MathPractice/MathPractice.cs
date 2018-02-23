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

            double Monday = 0.5 + 3.0;
            double adminMon = 7.5 - Monday;
            Console.WriteLine("Monday 19.02.2018 is: " + Monday + " - "  + "Admin is: " + adminMon);

            double Tuesday = 0.7 + 2.9;
            double adminTue = 7.5 - Tuesday;
            Console.WriteLine("Tuesday 20.02 is: " + Tuesday + " - " + "Admin is: " + adminTue);

            double Wednesday = 1.7 + 2.2;
            double adminWed = 7.5 - Wednesday;
            Console.WriteLine("Wednesday 21.02 is: " + Wednesday + " - " + "Admin is: " + adminWed);

            double Thursday = 1.8 + 2.0;
            double adminThur = 7.5 - Thursday;
            Console.WriteLine("Thursday 22.02 is: " + Thursday + " - " + "Admin is: " + adminThur);

            double Friday = 1.0 + 2.8;
            double adminFri = 7.5 - Friday;
            Console.WriteLine("Friday 23.02 is: " + Friday + " - " + "Admin is: " + adminFri);

            Console.ReadLine();

            /*
            Next iteration is to do this as a windows program with input fields. This is my first ever C# program to be made by moi
            */
        }
    }
}
