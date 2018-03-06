using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample
{
    class OperatorsExample
    {
        static void Main(string[] args)
        {
            int a = 7 + 9;
            Console.WriteLine(a); // 16

            int x = 4 * 10;
            int z = 22 * 3;
            float y = 45 * 48937;
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(y);

            string firstName = "Snipe";
            string lastName = "Hub";

            // Do not forget the space between them
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            // Ambiguous
            //    x + y / 100
            // Unambiguous, recommended
            //    x + (y / 100)


        }
    }
}
