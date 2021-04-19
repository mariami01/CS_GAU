using System;
namespace MidTerm
{
    public class ComplexNumber : Pair
    {
        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override int real
        {
            get
            {
                return myreal;
            }
            set
            {
                myreal = value;
            }

        }
        public override int imaginary
        {
            get
            {
                return myimaginary;
            }
            set
            {
                myimaginary = value;
            }

        }

        public static ComplexNumber operator +(ComplexNumber one, ComplexNumber two)
        {
            return new ComplexNumber(one.real + two.real, one.imaginary + two.imaginary);
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
    
}
