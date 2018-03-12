using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabor;

namespace NamespacesAndReferencingAssemblies // Part 18
{
    class Program
    {
        static void Main(string[] args)
        {

            Bob bob = new Bob();

            string html = bob.Lookup("http://www.google.com");

            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}
