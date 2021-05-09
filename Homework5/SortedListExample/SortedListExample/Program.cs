using System;
using System.Collections.Generic;

namespace SortedListExample
{
    class Example
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s = new SortedList<int, string>();

            s.Add(9, "Harry");
            s.Add(2, "Sally");
            s.Add(3, "Clarke");
            s.Add(1, "James");
            s.Add(7, "Emma");
            s.Add(6, "Susan");

            Console.WriteLine("Original SortedList elements:");

            foreach (KeyValuePair<int, string> i in s)
            {
                Console.WriteLine("Key: {0}     Value: {1}", i.Key, i.Value);
            }

            Console.WriteLine("\nCapacity = " + s.Capacity);

            s.Remove(3);
            s.Remove(6);

            Console.WriteLine("\nSortedList elements after deletion:");

            foreach (KeyValuePair<int, string> i in s)
            {
                Console.WriteLine("Key: {0}     Value: {1}", i.Key, i.Value);
            }


            Console.WriteLine("\nThe key 9 is present in SortedList: " + s.ContainsKey(3));
            Console.WriteLine("The value Monica is present in SortedList: " + s.ContainsValue("Monica"));
        }
    }
}
