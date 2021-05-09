using System;
using System.Collections;

namespace QueueExample
{
    class Example
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            Console.Write("Original queue: ");
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nCount = {0} ", q.Count);

            Console.Write("Element at the beginning of the queue is: {0}", q.Peek());

            q.Dequeue();
            q.Dequeue();
            Console.WriteLine();
            Console.Write("\n\nQueue after Dequeue() operation: ");
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }
        }
    }
}
