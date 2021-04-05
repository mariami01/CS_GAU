using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("num:");
            num = Convert.ToInt32(Console.ReadLine());


            if (num % 2 == 0)
            {
              Console.WriteLine("This number is even!");
            }
            else
            {
              Console.WriteLine("This number is odd!");
            }

    }
  }
}
