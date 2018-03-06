using System;

namespace ReferenceVariables
{
    class ReferenceVariable
    {
        static void Main(string[] args)
        {

            // Nullable Variables
            int i = 5;
            int? ni = i;

            Console.WriteLine(ni);  // 5

            // i = ni; // This will fail to compile
            Console.WriteLine(ni.HasValue); // True
            i = ni.Value;
            Console.WriteLine(i); // 5

            ni = null;
            Console.WriteLine(ni.HasValue); // false
            // i = ni.Value; // System.InvalidOperationException
            i = ni.GetValueOrDefault();
            Console.WriteLine(i); // 0
        }
    }
}
