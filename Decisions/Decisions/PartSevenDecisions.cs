using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartSevenDecisions
{
    class PartSeven
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter key.");
            //String userValue;
            //userValue = Console.ReadLine(); 
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            //string message = "";

            //if (userValue == "1")
            //    message = "You won a Billion Dollars!";
            //else if (userValue == "2")
            //    message = "You won a Ferrari!";
            //else if (userValue == "3")
            //    message = "You won a cat!";
            //else
            //    message = "Sorry, we didn't understand. You lose!";

            //Console.WriteLine(message);

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);
        }
    }
}
