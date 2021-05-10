using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiseowl
{
    public partial class frmToys : Form
    {
        public frmToys()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            // buy a couple of normal toys
            Toy t1 = new Toy("Games console", 99.99);
            t1.Buy();

            Toy t2 = new Toy("Lego set", 11.99);
            t2.Buy();

            // buy a cuddly toy (saying what type it is)
            //CuddlyToy t3 = new CuddlyToy("Flopsy rabbit", 5.99);
            //t3.Animal = "Rabbit";
            //t3.Buy();

            string s = "";
            foreach (Toy t in Toy.Toys)
            {
                s += t.Description + "\n";
            }

            MessageBox.Show(s.Trim(), "Purchases");
        }
    }
}
