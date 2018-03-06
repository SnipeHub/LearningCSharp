using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt"); // myReader variable // Make sure the values.txt file is located in the bin folder or it will not compile
            string line = ""; // declared an empty string

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close(); // make sure to close the while loop
            Console.ReadLine();
        }
    }
}
