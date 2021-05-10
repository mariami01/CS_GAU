using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiseowl
{
    class Toy
    {

        // collection of all of the toys bought
        public static List<Toy> Toys = new List<Toy>();

        // fields
        protected double price;
        protected string what;

        public Toy(string What, double Price)
        {
            what = What;
            price = Price;
        }

        public void Buy()
        {
            Toys.Add(this);
        }
        
        public virtual string Description {
            get { return what + " (£" + price.ToString("0.00") + ")"; }
        } 
    }
}
