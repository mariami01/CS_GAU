using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiseowl
{
    class CuddlyToy : Toy
    {
//        public BlindDate(Customer c1, Customer c2)
//    : base(c1, c2)
//{
//}

        // call base constructor
        public CuddlyToy(string What, double Price) : base(What,Price) {

        }

        // type of animal
        string animal;
        public string Animal
        {
            set { animal = value; }
        }

        // cuddly toys have different descriptions
        public override string Description
        {
            get { return "CUDDLY " + animal.ToUpper() + ": " +  what + " (£" + price.ToString("0.00") + ")"; }
        } 


    }
}
