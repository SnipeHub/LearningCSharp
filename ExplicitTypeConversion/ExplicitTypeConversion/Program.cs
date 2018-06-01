using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 5.1d;
            Console.WriteLine(myDouble); // 5.1

            long myLong = (long)myDouble;
            Console.WriteLine("double converted into a long:" + myDouble); // 5

            myDouble = 5e9d; // 5 * 10^9
            Console.WriteLine(myDouble); // 5000000000

            int myInt = (int)myDouble;  // from a long converted now to an int
            Console.WriteLine(myInt); // -2147483648
            Console.WriteLine(int.MinValue);
        }
    }
}
