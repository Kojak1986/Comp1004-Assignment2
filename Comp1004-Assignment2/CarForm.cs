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

        //Exit buttom ends app
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Clear button resets the form except for car colour
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TradeInTextBox.Text = "0";
            SubTotalTextBox.Text = BasePriceTextBox.Text;
            TotalTextBox.Text = null;
            AmountDueTextBox.Text = null;
            SalesTaxTextBox.Text = null;
            StereoCheckBox.Checked = false;
            LeatherCheckBox.Checked = false;
            CompNavCheckBox.Checked = false;
            BasePriceTextBox.BackColor = Color.White;
            AmountDueTextBox.BackColor = Color.White;



        }

        //When red is checked, picture is the red car and the appropriate cost is added to the base price
        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ColourPictureBox.Image = Comp1004_Assignment2.Properties.Resources.RedCar;

            if (BasePriceTextBox.Text == "$23,299.59" || BasePriceTextBox.Text == "$23,569.99")
            {
                BasePriceTextBox.Text = "$23,000.00";
            }

            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");
        }

        //When yellow is checked, picture is the yellow car and the appropriate cost is added to the base price
        private void YellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ColourPictureBox.Image = Comp1004_Assignment2.Properties.Resources.YellowCar;

            if (BasePriceTextBox.Text == "$23,000.00" || BasePriceTextBox.Text == "$23,569.99")
            {
                BasePriceTextBox.Text = "$23,299.59";
            }
            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");

        }

        //When green is checked, picture is the green car and the appropriate cost is added to the base price
        private void GreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ColourPictureBox.Image = Comp1004_Assignment2.Properties.Resources.GreenCar;

            if (BasePriceTextBox.Text == "$23,000.00" || BasePriceTextBox.Text == "$23,299.59")
            {
                BasePriceTextBox.Text = "$23,569.99";
            }
            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");
        }

        //Stereo check adds cost to the subtotal and also to the additional text box area
        private void StereoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double addop;
            double addopStereo;
            double stereo = 259.99;
            


            // if checked the value is injected into the additional items text box
            if (StereoCheckBox.Checked == true)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = stereo.ToString("C2");
                    

                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    addop = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    

                    addopStereo = stereo + addop;

                    AdditionalOptionsTextBox.Text = addopStereo.ToString("C2");
                    

                }
            }

            else
            {
                //if stereo is unchecked the value of the item is deleted from the additional items text box
                addop = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));

                addop = addop - stereo;
             
                AdditionalOptionsTextBox.Text = addop.ToString("C2");
                
            }

            
            // subtotal is calculated and injected into the subtotal textbox
            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");



        }

        //Leather check adds cost to the subtotal and also to the additional text box area
        private void LeatherCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            double addop;
            double addopLeather;
            double leather = 599.99;


            // if checked the value is injected into the additional items text box
            if (LeatherCheckBox.Checked == true)
            {
                if(AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = leather.ToString("C2");
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    addop = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));

                    addopLeather = leather + addop;

                    AdditionalOptionsTextBox.Text = addopLeather.ToString("C2");
                  
                }


            }
            else
            {
                addop = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
               
                addop = addop - leather;
               

               
                AdditionalOptionsTextBox.Text = addop.ToString("C2");
            }

            // subtotal is calculated and injected into the subtotal textbox
            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");
        }

        //Computer Navigation check adds cost to the subtotal and also to the additional text box area
        private void CompNavCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double addop;
            double addopNav;
            double nav = 759.99;

            // if checked the value is injected into the additional items text box
            if (CompNavCheckBox.Checked == true)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = nav.ToString("C2");
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    addop = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));

                    addopNav = nav + addop;

                    AdditionalOptionsTextBox.Text = addopNav.ToString("C2");
                   

                }


            }
            else
            {
                addop = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));

                addop = addop - nav;
               

               
                AdditionalOptionsTextBox.Text = addop.ToString("C2");

            }

            // subtotal is calculated and injected into the subtotal textbox
            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");

        }

        //Calculate button does all the necessary calculations and returns the total amounts
        //Uses a try catch to make sure the trade in amount is properly entered number
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            double subTotal = Convert.ToDouble((SubTotalTextBox.Text as string).TrimStart('$'));
            double tax;
            double totalSansTrade;
            double totalAmount;


            try
            {
                if (TradeInTextBox.Text == "0" || TradeInTextBox.Text == "")
                {
                    totalAmount = subTotal * 1.13;
                    tax = subTotal * 0.13;

                    SalesTaxTextBox.Text = tax.ToString("C2");
                    AmountDueTextBox.Text = totalAmount.ToString("C2");
                    TotalTextBox.Text = totalAmount.ToString("C2");
                    
                    
                }

                else if (TradeInTextBox.Text != "")
                {
                    double tradeIn = Convert.ToDouble((TradeInTextBox.Text as string).TrimStart('$'));
                    totalAmount = (subTotal - tradeIn) * 1.13;
                    totalSansTrade = subTotal * 1.13;
                    tax = subTotal * 0.13;

                    SalesTaxTextBox.Text = tax.ToString("C2");
                    AmountDueTextBox.Text = totalAmount.ToString("C2");
                    


                }
            }
            catch(Exception)
            {
                MessageBox.Show("Trade in value must be a number!");
            }



            
        }

        //Exit menue item exits app
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //calculate menu item performs calculate button click
        private void CalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
              CalculateButton.PerformClick();
        }

        //clear menu item performs clear button click
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearButton.PerformClick();
        }

        //about menu item describes the app
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for customizing your car and calculating your total. Choose whichever options you would like! We'll even discount your trade in value!", "Welcome!");
        }

        //colour change of baseprice and amount due boxes
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasePriceTextBox.BackColor = Color.Red;
            AmountDueTextBox.BackColor = Color.Red;
        }

        //colour change of baseprice and amount due boxes
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasePriceTextBox.BackColor = Color.Yellow;
            AmountDueTextBox.BackColor = Color.Yellow;
        }

        //colour change of baseprice and amount due boxes
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasePriceTextBox.BackColor = Color.Green;
            AmountDueTextBox.BackColor = Color.Green;
        }




        //font change of baseprice and amount due boxes and labels
        private void lucidaSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasePriceLabel.Font = new Font("Lucida Sans", 12, FontStyle.Regular);
            AmountDueLabel.Font = new Font("Lucida Sans", 12, FontStyle.Regular);

            BasePriceTextBox.Font = new Font("Lucida Sans", 12, FontStyle.Regular);
            AmountDueTextBox.Font = new Font("Lucida Sans", 12, FontStyle.Regular);

        }
        //font change of baseprice and amount due boxes and labels

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasePriceLabel.Font = new Font("Comic Sans", 12, FontStyle.Regular);
            AmountDueLabel.Font = new Font("Comic Sans", 12, FontStyle.Regular);

            BasePriceTextBox.Font = new Font("Comic Sans", 12, FontStyle.Regular);
            AmountDueTextBox.Font = new Font("Comic Sans", 12, FontStyle.Regular);
        }

        //font change of baseprice and amount due boxes and labels
        private void coriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasePriceLabel.Font = new Font("Courier New", 12, FontStyle.Regular);
            AmountDueLabel.Font = new Font("Courier New", 12, FontStyle.Regular);

            BasePriceTextBox.Font = new Font("Courier New", 12, FontStyle.Regular);
            AmountDueTextBox.Font = new Font("Courier New", 12, FontStyle.Regular);
        }

        //font change of baseprice and amount due boxes and labels
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasePriceLabel.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            AmountDueLabel.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            BasePriceTextBox.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            AmountDueTextBox.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }
    }
}
