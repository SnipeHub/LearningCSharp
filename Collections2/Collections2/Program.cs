using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2 // Part 22
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() { Make = "Hyundai", Model = "N30 Turbo" };
            Car car2 = new Car() { Make = "Honda", Model = "Civic" };
            Car car3 = new Car() { Make = "Nissan", Model = "GTR" };

            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Hyundai", Model = "N30 Turbo"},
                new Car { Make = "Honda", Model = "Civic"},
                new Car { Make = "Nissan", Model = "GTR"}
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
