using System;
namespace MidTerm
{
    public class Money : Pair
    {
        public override int Lari {
            get {
                return myLari;
            }
            set
            {
                myLari = value;
            }

        }
        public override int Tetri
        {
            get
            {
                return myTetri;
            }
            set
            {
                myTetri = value;
            }

        }

        public override string ToString()
        {
            return (String.Format("{0}GEL and {1}Tetri", myLari, myTetri));
        }
    }
}

