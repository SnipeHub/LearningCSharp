using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Taken from https://channel9.msdn.com/series/C-Fundamentals-for-Absolute-Beginners/06 */

namespace PartSixVariables
{
    class Variables
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            */

            //string myFirstName;
            //myFirstName = "Snipe";

            //string myFirstName = "Snipe";

            //var myFirstName = "Snipe";
            //Console.WriteLine("My Name is " + myFirstName);

            int x = 7;
            string y = "5";
            //string y = "Snipe";
            string myFirstTry = x.ToString() + y;

            //int mySecondTry = x + y;
            int mySecondTry = x + int.Parse(y);

            Console.WriteLine(myFirstTry);
            //Console.WriteLine(mySecondTry);

            

        }
    }
}
