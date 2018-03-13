using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope2 // Part 19 
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.DoSomething(); // unable to see the private string, can only call from the public


        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!"; // used as an example, not something you would do to call hello world.
        }
    }
}
