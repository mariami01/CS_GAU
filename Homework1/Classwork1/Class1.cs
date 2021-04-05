using System;

public class Class1
{
  class Program
  {
    static void Main()
    {
      double num;

      Console.WriteLine("num:");
      num = Convert.ToInt32(Console.ReadLine());


      if (num % 2 == 0)
      {
        Console.WriteLine("This umber is even!");
      }
      else
      {
        Console.WriteLine("This umber is odd!");
      }
    }
  }
}
