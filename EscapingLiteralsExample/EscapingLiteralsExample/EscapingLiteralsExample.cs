using System;

namespace EscapingLiteralsExample
{
    class EscapingLiteralsExample
    {
        static void Main(string[] args)
        {

            // An ordinary character
            char character = 'a';
            Console.WriteLine(character);

            // Unicode characetr code in hexadecimal format
            character = '\u003A';
            Console.WriteLine(character);

            // Assigning the single quotation character (escaped as \')
            character = '\'';
            Console.WriteLine(character);

            // Assigning the backlash character (escaped as \\)
            character = '\\';
            Console.WriteLine(character);

            // Console output:
            // a
            // :
            // '
            // \

        }
    }
}
