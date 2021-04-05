using System;
namespace task1
{
    public abstract class Shape
    {
        public abstract double GetPerim();
        
    }

    public class Rectangle : Shape
    {
        protected double length, width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetPerim()
        {
            return (length + width) * 2;

        }
    }


    public class Triangle : Shape
    {
        protected double side1, side2, side3;
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double GetPerim()
        {
            return side1 + side2 + side3;

        }
    }
}
