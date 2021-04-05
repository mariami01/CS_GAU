using System;

namespace Classwork1
{
    class Program
    {
        static void Main()
        {
          float y;
          int x;

          Console.WriteLine("x:");
          x = Convert.ToInt32(Console.ReadLine());

          y = 1 + x + (x * x) / 2;
          Console.WriteLine("y= " + y);
        }
    }
}
