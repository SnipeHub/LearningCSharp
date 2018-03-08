using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime // Part 16 Bob Tabor 
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // set properties

            Car myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");



            myOtherCar = null;
            myCar = null;


        }
    }

    class Car
    {
        public string Make { get; set; } // To auto create these lines, type prop then press TAB twice, then TAB to cycle through to change the inputs followed by enter when done
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            // You could also add in a link to a database or config file
            // Going to hard code this instance
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        /*
        public Car(string SomeOtherInputParameter, string model, int year, string color)
        {
            Make = SomeOtherInputParameter;
            Model = model;
            Year = year;
            Color = color;
        }
        */

        public static void MyMethod()
        {

        }

    }
}
