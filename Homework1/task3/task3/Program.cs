using System;

namespace task3
{
    class Program
    {
        static void Main()
        {
          int[] arr = new int[100];
          int i, n, sum = 0;


          Console.Write("How many elements do you want me to store in array? :) ");
          n = Convert.ToInt32(Console.ReadLine());
          Console.Write("Input {0} elements in the array :\n", n);

          for(i=0; i<n; i++)
          {
            Console.Write("Element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
          }
          for (i = 0; i < n; i++)
          {
                sum += arr[i];
          }

          Console.Write("I calculated the sum of all array elements for you ^.^ sum=  {0}\n\n", sum);
    }
    }
}
