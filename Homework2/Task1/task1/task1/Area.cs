using System;
namespace task1
{
    class Shape
    {
        public virtual double area()
        {
            return 0;
        }
    }

    class Square : Shape
    {
        private double side;
        public Square(double s)
        {
            side = s;
        }
        public override double area()
        {
            return (side * side);
        }
    }
    class Triangle : Shape
    {
        private double tbase;
        private double theight;
        public Triangle(double b, double h)
        {
            tbase = b;
            theight = h;
        }
        public override double area()
        {
            return (0.5 * tbase * theight);
        }
    }

}
