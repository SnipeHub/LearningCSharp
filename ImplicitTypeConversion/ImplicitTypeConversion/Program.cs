using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            Console.WriteLine(myInt); // 5
            // Here is where we change myInt into a long
            long myLong = myInt;
            Console.WriteLine(myLong); // 5
            Console.WriteLine(myLong + myInt); // 10

            // There is no data loss when converting types of smaller range to types with a larger range.
        }
    }
}
