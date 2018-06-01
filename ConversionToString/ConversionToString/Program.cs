using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            string sum = "Sum = " + (a + b);
            Console.WriteLine(sum);

            string incorrect = "Sum = " + a + b;
            Console.WriteLine(incorrect);

            Console.WriteLine("Perimeter = " + 2 * (a + b) + ". Area = " + (a * b) + ".");
        }
    }
}
