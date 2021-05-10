using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_CSharp_exercises
{
    public partial class frmMovableButtons : Form
    {
        public frmMovableButtons()
        {
            InitializeComponent();
        }
        
        private void btnMove_Click(object sender, EventArgs e)
        {

            // create a new movable button
            MovableButton b = new MovableButton(btn);

            // say how to move it
            b.Distance = (int)nudMovement.Value;
                        
            // create new instance of delegate
            MovingButton iWantToMoveItMoveIt = null;

            // get it so that this delegate has two methods assigned to it
            iWantToMoveItMoveIt += b.MoveDown;
            iWantToMoveItMoveIt += b.MoveRight;

            // now run the events associated with delegate
            b.Move(iWantToMoveItMoveIt);

        }

        private void btnMoveHome_Click(object sender, EventArgs e)
        {

            // create a new movable button
            MovableButton b = new MovableButton(btn);

            // say how to move it
            b.Distance = (int)nudMovement.Value;
                        
            // create new instance of delegate
            MovingButton iWantToMoveItMoveIt = null;

            // start at top left
            iWantToMoveItMoveIt += b.MoveHome;

            // get it so that this delegate has two methods assigned to it
            iWantToMoveItMoveIt += b.MoveDown;
            iWantToMoveItMoveIt += b.MoveRight;

            // now run the events associated with delegate
            b.Move(iWantToMoveItMoveIt);
        }

        
    }
}
