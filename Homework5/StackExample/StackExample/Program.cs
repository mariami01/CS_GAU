using System;
using System.Collections;

namespace StackExample
{
    class Example
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('w');
            st.Push('x');
            st.Push('y');
            Console.WriteLine("Stack = ");
            foreach (char ch in st)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            st.Push('s');
            st.Push('t');
            st.Push('u');
            st.Push('v');
            Console.WriteLine("Stack after adding two elements... ");
            foreach (char ch in st)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Pop a value!");
            st.Pop();
            Console.WriteLine("Current stack:");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\nPop another value!");
            st.Pop();
            Console.WriteLine("Current stack:");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }
    }
}
