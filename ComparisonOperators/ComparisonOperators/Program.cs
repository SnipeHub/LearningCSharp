using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators // Page 147 Fundamentals of Computer Programming
{   
    class Program
    {
        static void Main(string[] args)
        {

            /* - greater than ( > )
           - less than ( < )
           - greater than or equal to ( >= )
           - less than or equal to ( <= )
           - equality ( == )
           - difference ( != )
           Comparison operators have lower priority than arithmetical operators, but higher than
           assignment operators.
        */

            int x = 10, y = 5;

            Console.WriteLine("If x = 10, and y = 5, then the following must be..." + "\n");
            Console.WriteLine("  x > y : " + (x > y));    // True
            Console.WriteLine("  x < y : " + (x < y));    // False
            Console.WriteLine("  x >= y : " + (x >= y));  // True
            Console.WriteLine("  x <= y : " + (x <= y));  // False
            Console.WriteLine("  x == y : " + (x == y));  // False
            Console.WriteLine("  x != y : " + (x != y) + "\n");  // True
        }
    }
}
