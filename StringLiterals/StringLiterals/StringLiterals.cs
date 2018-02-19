using System;

namespace StringLiterals
{
    class StringLiterals
    {
        static void Main(string[] args)
        {

            // Quoted strings are often used for the file system path names

            string quotation = "\"Hello, Jude\", he said.";
            Console.WriteLine(quotation);

            string path = "C:\\Windows\\Notepad.exe";
            Console.WriteLine(path);

            string verbatim = @"The \ is not escaped as \\.
            I am at a new line.";
            Console.WriteLine(verbatim);

            // Console output:
            // "Hello, Jude", he said.
            // C:\Windows\Notepad.exe
            // The \ is not escaped as \\.
            // I am at a new line.
        }
    }
}
