using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations
{
    class ForIterationsPart9
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) // i++ - This means you are incrementing the value of 'i' by 1. This will increment by 1 until it reaches 10
            {
                //Console.WriteLine(i.ToString());

            if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break; // used to break out of the code block
                }
            }

            for (int myValue = 0; myValue < 12; myValue++) // This line was created by first typing the "for" statement, then hitting the TAB key twice to auto type the rest ready for editng
            {
                Console.WriteLine(myValue);
            }


            Console.ReadLine();
        }
    }
}
