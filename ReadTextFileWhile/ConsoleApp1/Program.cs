using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                StreamReader myReader = new StreamReader("Values.txt"); // myReader variable // Make sure the values.txt file is located in the bin folder or it will not compile
                string line = ""; // declared an empty string

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }

                myReader.Close(); // make sure to close the while loop


            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. Are you sure the DIRECTORY exists?"); // this will come up if the directory cant be found. To make use of these errors, change the name of
                // Vlaues.txt to something else, or add a new file directory.
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Something didn't work correctly: {0}", e.Message); // This will come up if the direcotry is correct, but cant find the file
            }
            finally
            {
                // Perform any cleanup to roll back the data or close connections
                // to files, database, network, etc.
            }


            Console.ReadLine();
        }
    }
}
