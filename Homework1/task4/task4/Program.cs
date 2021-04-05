using System;

namespace task4
{
    class Program
    {
        static void Main()
        {
          int[] arr = new int[100];
          int n, i, max=arr[0];

          Console.Write("How many elements do you want me to store in array? :) : ");
          n = Convert.ToInt32(Console.ReadLine());
          Console.Write("Input {0} elements in the array :\n", n);

          for (i = 0; i < n; i++)
          {
            Console.Write("Element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
          }

          for (i = 1; i < n; i++)
          {
            Console.WriteLine(arr[i]);

            if (arr[i] > max)
            {
              max = arr[i];
            }
          }

          Console.WriteLine("max array element is " + max);
    }
    }
}
