using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp1004_Assignment2
{
    public partial class AutoCentreForm : Form
    {
        public AutoCentreForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            {
                //Instantiate the next form
                CarFormYellow yellow = new CarFormYellow();

                //Save a reference to the current for in a preoperty of next form
                yellow.PreviousForm = this;

                //show next form
                yellow.Show();

                //Hide this one
                this.Hide();
            }
        }
    }
}
