using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndertstandingScope // Part 19
{
    class Program
    {
        private static string k = ""; // k defined outside. A private method can only be called from inside the private, public, from outside

        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine("l: " + l); // Wont work outside of the if block
            }

            Console.WriteLine("Outside of the for: " + j);
            //Console.WriteLine("k: " + k);
            helperMethod();
        }

        static void helperMethod()
        {
            Console.WriteLine("k from the helpermethod: " + k); // works as it was defined outside
        }
    }
}
