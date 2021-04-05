using System;

namespace Testing
{
    class input
    {
        private static int num1, num2, result;
        public void add()
        {
            result = num1 + num2;
            Console.WriteLine("\n\nAdd = {0}", result);
            Console.ReadLine();
        }

        // Creating property for storing value in num1
        public int Number1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }

        // Creating property for storing value in num2
        public int Number2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            input inp = new input();
            Console.Write("Enter number 1st:\t");
            inp.Number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2nd:\t");
            inp.Number2 = Convert.ToInt32(Console.ReadLine());

            inp.add();
        }
    }

}
