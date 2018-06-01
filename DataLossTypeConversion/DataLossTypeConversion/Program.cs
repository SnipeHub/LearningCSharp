using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLossTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long myLong = long.MaxValue;
            int myInt = (int)myLong;

            Console.WriteLine(myLong); // 9223372036854775807
            Console.WriteLine(myInt);  // -1

            float heightInMeters = 1.74f; // Explicit conversion
            double maxHeight = heightInMeters; // Implicit
            double minHeight = (double)heightInMeters; // Explicit
            float actualHeight = (float)maxHeight; // Explicit

            float maxHeightFloat = maxHeight; // Compilation error
        }
    }
}
