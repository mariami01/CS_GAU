using System;
namespace task2
{
    class Figure
    {
        public virtual float Perimenter()
        {
            return 0;
        }
    }

    class child : Figure
    {
        public float side1;
        public float side2;
        public float side3;
        public float side4;

        public child(float a, float b, float c, float d)
        {
            side1 = a;
            side2 = b;
            side3 = c;
            side4 = d;
        }

        public override float Perimenter()
        {
            return side1+side2+side3+side4;
        }
    }
}
