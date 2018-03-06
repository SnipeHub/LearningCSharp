using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string csharp = "C#";
            string dotnet = ".NET";
            string csharpDotNet = csharp + dotnet;
            Console.WriteLine(csharpDotNet);

            string csharpDotNet5 = csharpDotNet + " " + 5;
            Console.WriteLine(csharpDotNet5);
        }
    }
}
