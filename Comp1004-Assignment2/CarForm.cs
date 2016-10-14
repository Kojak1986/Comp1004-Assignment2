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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TradeInTextBox.Text = null;
            AdditionalOptionsTextBox.Text = null;
            SubTotalTextBox.Text = null;
            TotalTextBox.Text = null;
            AmountDueTextBox.Text = null;
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ColourPictureBox.Image = Comp1004_Assignment2.Properties.Resources.RedCar;

            if (BasePriceTextBox.Text == "$23,299.59" || BasePriceTextBox.Text == "$23,569.99")
            {
                BasePriceTextBox.Text = "$23,000.00";
            }
        }

        private void YellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ColourPictureBox.Image = Comp1004_Assignment2.Properties.Resources.YellowCar;

            if (BasePriceTextBox.Text == "$23,000.00" || BasePriceTextBox.Text == "$23,569.99")
            {
                BasePriceTextBox.Text = "$23,299.59";
            } 
            
        }

        private void GreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ColourPictureBox.Image = Comp1004_Assignment2.Properties.Resources.GreenCar;

            if (BasePriceTextBox.Text == "$23,000.00" || BasePriceTextBox.Text == "$23,299.59")
            {
                BasePriceTextBox.Text = "$23,569.99";
            }
        }

        private void StereoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
                 
        }
    }
}
