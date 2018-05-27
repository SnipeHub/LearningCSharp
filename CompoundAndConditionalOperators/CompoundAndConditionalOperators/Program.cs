using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundAndConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        int x = 2;
                        int y = 4;

                        x *= y; // Same as x = x * y;
                        Console.WriteLine(x); // 8

                        // The most common operators are += adds a value to the right, or -= which subtracts from the right value of the left one
            */

            int x = 6;
            int y = 4;

            Console.WriteLine(y *= 2); // 8 "4 * 2 = 8"
            int z = y = 3;             // y=3 and z=3

            Console.WriteLine("z = " + z);  // 3
            Console.WriteLine(x |= 1);      // 7
            Console.WriteLine(x += 3);      // 10
            Console.WriteLine(x /= 2);      // 5

            // Conditional Operator examples. It works like this: if operand1 is set to true , the operator returns as a result
            // operand2. Otherwise(if operand1 is set to false ), the operator returns as a result operand3.

            /* During the execution, the value of the first argument is calculated. If it has
               value true , then the second (middle) argument is calculated and it is
               returned as a result. However, if the calculated result of the first argument is
               false , then the third (last) argument is calculated and it is returned as a result.
            */

            int a = 6;
            int b = 4;
            Console.WriteLine(a > b ? "a>b" : "b<=a");  // a>b

            int num = a == b ? 1 : -1; // num will have value -1
            Console.WriteLine(num);
        }
    }
}
