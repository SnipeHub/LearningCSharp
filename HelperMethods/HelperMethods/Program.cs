using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods // Part 11
{
    class Program
    {
        static void Main(string[] args)  // void means nothing is returned, only delegates responsability
        {
            // string myValue = superSecretFormula("world");
            string myValue = superSecretFormula("sunshine"); // If you remove the word "sunshine" from the method(), it will default to the next one below
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            // cool stuff here
            return "Hello World!";
        }

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}!", name);
        }
    }
}
