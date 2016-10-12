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
    public partial class CarFormYellow : Form
    {

        //declare a property that has a shape of the previous form
        public AutoCentreForm PreviousForm { get; set; }
        
        public CarFormYellow()
        {
            InitializeComponent();
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //show the previous form
            this.PreviousForm.Show();

            //close this form to prevent memory leaks
            this.Close();
        }
    }
}
