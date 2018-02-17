using System;

namespace CharacterTypes
{
    class CharacterType
    {
        static void Main(string[] args)
        {

            // variables
            char ch = 'a';

            Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            ch = 'b';

            Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            ch = 'A';

            Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);

            // Is is printing the Unicode value from the char list.
            // Console output:
            // The code of 'a' is: 97
            // The code of 'b' is: 98
            // The code of 'A' is: 65
        }
    }
}
