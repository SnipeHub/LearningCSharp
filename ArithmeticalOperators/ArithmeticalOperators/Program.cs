using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0; // 17 divided by 4.0
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide); // 4.25
            Console.WriteLine(squareArea); // 18.0625

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b); // 9
            Console.WriteLine(a + (b++)); // 9
            Console.WriteLine(a + b); // 10
            Console.WriteLine(a + (++b)); // 11
            Console.WriteLine(a + b); // 11
            Console.WriteLine(14 / a); // 2
            Console.WriteLine(14 % a); // 4

            int one = 1;
            int zero = 0;
            // Console.WriteLine(one / zero); DivideByZeroException

            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / zero); // -Infinity
            Console.WriteLine(one / dZero); // Infinity
        }
    }
}
