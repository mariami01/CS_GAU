using System;

namespace task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(8, 5);
            Triangle tr = new Triangle(3,4,5);
            Console.WriteLine("The perimeter of the rectangle is: {0}\n", rec.GetPerim());
            Console.WriteLine("The perimeter of the triangle is: {0}\n", tr.GetPerim());
        }
    }
}
