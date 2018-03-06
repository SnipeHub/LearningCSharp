using System;

namespace ObjectVariable
{
    class ObjectVariable
    {
        static void Main(string[] args)
        {

            // Object variables
            object container1 = 5;
            object container2 = "Five";

            // Print to console
            Console.WriteLine("The value of container1 is: " +  container1);
            Console.WriteLine("The value of container2 is: " + container2);

            // Console output:
            // The value of container1 is: 5
            // The value of container2 is: Five.
        }
    }
}
