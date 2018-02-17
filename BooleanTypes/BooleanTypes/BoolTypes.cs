using System;

namespace BooleanTypes
{
    class BoolTypes
    {
        static void Main(string[] args)
        {
            // variables
            int a = 1;
            int b = 2;
            // which one is greater?
            bool greaterAB = (a > b);
            // Is 'a' equal to 1?
            bool equalA1 = (a == 1);

            // Print the results on the console
            if (greaterAB)
            {
                Console.WriteLine("A > B");
            }
            else
            {
                Console.WriteLine("A <= B");
            }
            Console.WriteLine("greaterAB = " + greaterAB);
            Console.WriteLine("equalA1 = " + equalA1);

            // Console output:
            // A <= B
            // greaterAB = False
            // equalA1 = True
        }
    }
}
