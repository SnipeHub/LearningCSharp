using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPrt13
{
    class Program
    {
        static void Main(string[] args)
        {
            string backString = "Go to your c:\\ drive"; // To get the backslash, just add an extra \, so \\
            Console.WriteLine(backString);

            string lfString = "My \"so called\" life"; // double quotes anything inside \"  \"
            Console.WriteLine(lfString);

            string nlString = "What if I need \n a new line?"; // Places the rest on a new line after \n
            Console.WriteLine(nlString);

            string placString = string.Format("{0}!", "Bonzai");
            Console.WriteLine(placString);

            string modString = string.Format("Make: {0} (Model: {1})", "BMW", "760li");
            Console.WriteLine(modString);

            string dollarString = string.Format("{0:C}", 123.45); // $123.45
            Console.WriteLine(dollarString);

            string myString = string.Format("{0:N}", 2345917);
            Console.WriteLine(myString);

            string percString = string.Format("{0:P}", .465);
            Console.WriteLine(percString);

            string seqString = string.Format("Phone number: {0:(###) ###-####}", 8794360980); // If you have extra numbers, it shifts everything to the left, so an extra number will cause there to be 4 numbers in the bracket section.
            // In order to correct it, you need to place enough pounds in the required location.
            Console.WriteLine(seqString);

            
            string incrementString = "";
            
            for (int i = 0; i < 101; i++) // For int i starts at 0, if i is below 100 increment by one until it reaches less then 100, you could also place an = after the <
            {
                //incrementString = incrementString + "--" + i.ToString(); // Longer form
               
                incrementString += "--" + i.ToString(); // Shorter form
            }
            Console.Write(incrementString);
            

            StringBuilder buiString = new StringBuilder(); // using the StringBuilder is prefered over the previous way, much faster

            for (int i = 0; i < 100; i++)
            {
                buiString.Append("--");
                buiString.Append(i);
            }
            Console.WriteLine(buiString.ToString()); // Placing .ToString() here is optional

            string songString = "That summer we took threes across the board";
            songString = songString.Substring(5, 14); // Takes the string 5 characters in up to 14
            Console.WriteLine(songString);

            string upString = "That winter we took threes across the river";
            upString = upString.ToUpper(); // Converts to upper case
            Console.WriteLine(upString);

            string repString = "That summer we took threes across the board";
            repString = repString.Replace(" ", "--"); // Replaces spaces with --
            Console.WriteLine(repString);

            string formString = "  That summer we took threes across the board  "; // Look Carefully, I added extra spaces for this
            formString = String.Format("Length before: {0} -- After: {1}", formString.Length, formString.Trim().Length); // Print out the length of the string, The Trim method will chop off extra spaces at the very beginning and at the end and look at the length
            Console.WriteLine(formString);


            Console.ReadLine();
        }
    }
}
