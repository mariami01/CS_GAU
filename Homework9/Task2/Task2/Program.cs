using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text:");

            string text = Console.ReadLine();

            string replacedText = text.Replace("i", "s");

            Console.WriteLine("Your Text is '{0}'. We replaced 'i' with 's'. Final text: {1}", text, replacedText);
        }
    }
}
