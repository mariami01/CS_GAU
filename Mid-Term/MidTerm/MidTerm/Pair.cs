using System;
namespace MidTerm
{
    public abstract class Pair
    {
        //public abstract void Show();
        //public virtual double Arithmetic();
        //public abstract int ShowMoney();

        //public abstract string ToSring();
        public virtual int Lari { get; set; }
        public virtual int Tetri { get; set; }
        protected int myLari;
        protected int myTetri;

        public virtual int real { get; set; }
        public virtual int imaginary { get; set; }
        protected int myreal;
        protected int myimaginary;

    }
}
