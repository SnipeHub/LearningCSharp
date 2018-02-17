﻿using System;

namespace IntegerTypes
{
    class IntegerExamples
    {
        static void Main(string[] args)
        {
            // Declare variables
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;

            // Print the result to console
            Console.WriteLine(centuries + " centuries are " + years + " years, or " + days + " days, or " + hours + " hours.");

            // Console output:
            // 20 centuries are 2000 years, or 730480 days, or 17531520 hours.

            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue); // 18446744073709551615
        }
    }
}
