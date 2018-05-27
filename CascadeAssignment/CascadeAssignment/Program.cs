using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascadeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The following is known as a cascade assignment, assignments are carried out consecutively from
                right to left
            */
            int x, y, z;    // We initialize three variables
            x = y = z = 25;     // Then we assign them the value of 25

            Console.WriteLine("The following variables are assigned as: x = y = z = 25" + "\n" + "This is known as a Cascade Assignment.");

            Console.WriteLine("x = : " + x);
            Console.WriteLine("y = : " + y);
            Console.WriteLine("z = : " + z);
        }
    }
}
