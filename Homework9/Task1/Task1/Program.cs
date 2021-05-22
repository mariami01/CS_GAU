using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 12.1.4

            //string text = "Hello World!";
            Console.WriteLine("Text:");

            string text = Console.ReadLine();

            string symbol = "!";

            int numberOfTrues = Regex.Matches(text, symbol).Count;

            Console.WriteLine( "The symbol '!' occures {0} times in a string.",numberOfTrues);

        }
    }
}
