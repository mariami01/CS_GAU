using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Updated numbers: ");
            UpdatedNumber(num1,ref num2);
            Console.WriteLine(num2);
        }

        public static void UpdatedNumber(int num1, ref int num2)
        {
            num2 = num1 * num1;
        }
    }
}
