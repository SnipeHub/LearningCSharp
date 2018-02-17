using System;

namespace PrecisionTypes
{
    class PrecisionFloatDouble
    {
        static void Main(string[] args)
        {
            // Variables
            float floatPI = 3.141592653589793238f;
            double doublePI = 3.141592653589793238;

            // Print results to console
            Console.WriteLine("Float PI is: " + floatPI + " This has the precision of 7 digits");
            Console.WriteLine("Double PI is: " + doublePI + " This has the precision of 15-16 digits");

            // Errors in calculations
            float f = 0.1f;
            Console.WriteLine(f); // 0.1 (correct due to rounding)
            double d = 0.1f;
            Console.WriteLine(d); // 0.100000001490116 (incorrect)
            float ff = 1.0f / 3;
            Console.WriteLine(ff); // 0.3333333 (correct due to rounding)
            double dd = ff;
            Console.WriteLine(dd); // 0.333333343267441 (incorrect)
        }
    }
}
