using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[5]; // Defining how many in the array, in this case 5.

            numbers[0] = 4; // must start with [0] element
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers.Length);

            /*
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 }; // Here we don't define how many, we just give how many we want instead.

            Console.WriteLine(numbers[3].ToString());
            Console.ReadLine();
            */

            /*
            string[] names = new string[] { "Eddie", "Alex", "Michael", "John" };

            foreach (string name in names) // This is displaying each name one after the other in the console.
            {
                Console.WriteLine(name);
            }
            */

            /*
            string zig = "You can get what you want out of life" +          // Just making this long sentence be on two lines, just makes it easier to read the code.
                " if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray(); // Defining an array called char
            Array.Reverse(charArray);               // Displays the array from zig in reverse

            foreach (char zigChar in charArray)
                Console.Write(zigChar);             // Displays it on a single line
            */

        }
    }
}
