using System;

namespace declareIntializeVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // declare and initialize variables
            byte centuries = 20;
            ushort years = 2000;
            decimal decimalPI = 3.141592653589793238m;
            bool isEmpty = true;
            char ch = 'a';
            string firstName = "Snipe";

            ch = (char)5;
            char secondChar;
            // Here we use an already initialized variable and reassign it
            secondChar = ch;

            Console.WriteLine("Hi " + firstName + ", You still have " + centuries + " centuries to go"); // Snipe, 20

            // page 127
        }
    }
}
