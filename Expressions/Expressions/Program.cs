using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args) // Pg 158
        {
            int r = (150 - 20) / 2 + 5;

            // Expression for calculating the surface of the circle
            double surface = Math.PI * r * r;

            // Expression for calculating the perimeter of the circle
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("r = " + r);
            Console.WriteLine("surface = " + surface);
            Console.WriteLine("Perimeter = " + perimeter);

            // Side effects of expressions
            int a = 5;
            int b = ++a;

            Console.WriteLine("\n" + "Side effects, the second answer should increment by 1, but the answer has stayed the same");
            Console.WriteLine(a); // 6
            Console.WriteLine(b); // 6
        }
    }
}
