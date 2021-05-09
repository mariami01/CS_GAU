using System;
using System.Collections;

namespace ArrayListExample
{
    class Example
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(100);
            arr.Add(120);
            arr.Add(90);
            arr.Add(60);
            arr.Add(200);
            arr.Add(110);
            arr.Add(130);
            arr.Add(180);
            arr.Add(195);
            arr.Add(165);
            arr.Add(80);
            arr.Add(99);
            arr.Add(145);
            arr.Add(198);
            arr.Add(210);


            Console.Write("ArrayList elements = ");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nCount = " + arr.Count);

            Console.WriteLine("Capacity = " + arr.Capacity);

            Console.WriteLine("Element {0} is \"{1}\"", 2 + "th", arr[1]);
            Console.WriteLine("Element {0} is \"{1}\"", 4 + "th", arr[3]);
            Console.WriteLine("Element {0} is \"{1}\"", 6 + "th", arr[5]);
            Console.WriteLine("Element {0} is \"{1}\"", 8 + "th", arr[7]);
        }
    }
}
