using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Side of your square:");
            double squareSide = Convert.ToDouble(Console.ReadLine());

            Square s = new Square(squareSide);
            Console.WriteLine("Area of Square = {0}", s.area());

            Console.WriteLine("Height of your triangle:");
            double theight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Base of your triangle:");
            double tbase = Convert.ToDouble(Console.ReadLine());

            Triangle t = new Triangle(tbase ,theight);
            Console.WriteLine("Area of Triangle = {0}", s.area());
        }
    }
}
