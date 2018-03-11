using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance // Part 17 Bob Tabor Class inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Blue";
            myCar.Year = 2005;

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "White";
            myTruck.TowingCapacity = 40000; // Now we need to add this as the car does not have a tow capacity option.
            printVehicleDetails(myTruck); // Here we are using the printVehicleDetails and parse into the (myTruck)  

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle's details: {0}",
                vehicle.FormatMe());         
        }

    }

    abstract class Vehicle // Creating a Vheicle class is more appropriate in our situation
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();
    }

    class Car : Vehicle
    {
        public override string FormatMe() // adding virtual allows override to take over but the base still remains. If abstract is used, means you have to use override, there 
            // will be no support from this. Deriving from the car to truck may not be appropriate.
        {
            return String.Format("{0} - {1} - {2} - {3}", // The "," just allows you to type your code on a new line. Also the format order in which the details will be displayed.
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }

     sealed class Truck : Vehicle // The semi-colon means the new Truck class will inherit from the previous Car class. Sealed means no one can inherit from this class.
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe() // use override here to make this the main ruling FormatMe
        {
            return String.Format("{0} - {1} - {2} Towing tonnage", // The "," just allows you to type your code on a new line. Also the format order in which the details will be displayed.
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
    }
}
