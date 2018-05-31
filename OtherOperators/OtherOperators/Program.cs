using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // The "." operator, or access operator is used to access the member fields or methods of a class or object.
            // example:
            Console.WriteLine(DateTime.Now);

            // Square Brackets [] Operator
            // Square brackets are used to access elements of an array by index, they are also called the indexer. 
            // Indexers are also used for accessing characters in a string. Example:
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]); // 1

            string str = "Hello";
            Console.WriteLine(str[1]); // e

            // Bracket () operators are used to override the priority of execution of expressions and operators

            // Operator "??" This operator is similar to the conditional operator "?:" The difference is that it is placed between two operands and returns the left
            // operand only if its value is not null, otherwise it returns the right operand. Example:
            int? a = 5;
            Console.WriteLine(a ?? -1); // 5
            string name = null;
            Console.WriteLine(name ?? "(no name)"); // (no name)

            // More examples;

            int b = 6;
            int c = 3;

            Console.WriteLine(b + c / 2);                        // 7
            Console.WriteLine((b + c) / 2);                      // 4

            string s = "Beer";
            Console.WriteLine(s is string);                      // True

            string notNullString = s;
            string nullString = null;
            Console.WriteLine(nullString ?? "Unspecified");      // Unspecified
            Console.WriteLine(notNullString ?? "Specified");     // Beer
        }
    }
}
