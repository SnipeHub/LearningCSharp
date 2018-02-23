using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);              // false
            Console.WriteLine(a || b);              // true
            Console.WriteLine(!b);                  // true
            Console.WriteLine(b || true);           // true
            Console.WriteLine((5 > 7) ^ (a == b));  // false

            // Laws of De Morgan
            // !(a && b) == (!a || !b)
            // !(a || b) == (!a && !b)
        }
    }
}
