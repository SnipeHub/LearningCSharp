using System;

namespace Strings
{
    class StringVariable
    {
        static void Main(string[] args)
        {

            // variables (String variables)
            string firstName = "John";
            string lastName = "Smith";
            // Added extra string variable
            string Title = "Mr";
            string fullName = Title + " " + firstName + " " + lastName;

            // print to console
            Console.WriteLine("Hello, " + firstName + "!");
            Console.WriteLine("Your full name is " + fullName + ".");

            //// Console output:
            // Hello, John!
            // Your full name is Mr John Smith.
        }
    }
}
