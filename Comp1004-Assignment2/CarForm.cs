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
            SubTotalTextBox.Text = BasePriceTextBox.Text;
            TotalTextBox.Text = null;
            AmountDueTextBox.Text = null;
            SalesTaxTextBox.Text = null;

            if (StereoCheckBox.Checked == true)
            {
                StereoCheckBox.Checked = false;
            }
            if (LeatherCheckBox.Checked == true)
            {
                LeatherCheckBox.Checked = false;
            }
            if (CompNavCheckBox.Checked == true)
            { 
            CompNavCheckBox.Checked = false;
        }
            
        }

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

        private void StereoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double addop;
            double addopStereo;
            double stereo = 259.99;
            



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
                addop = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));

                addop = addop - stereo;
             
                AdditionalOptionsTextBox.Text = addop.ToString("C2");
                
            }

            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");



        }

        private void LeatherCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            double addop;
            double addopLeather;
            double leather = 599.99;
            


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

            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");
        }

        private void CompNavCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double addop;
            double addopNav;
            double nav = 759.99;
          

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

            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double addOptText = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + addOptText;

            SubTotalTextBox.Text = subTotal.ToString("C2");

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            double subTotal = Convert.ToDouble((SubTotalTextBox.Text as string).TrimStart('$'));
            double tax;
            double totalSansTrade;
            double totalAmount;


            try
            {
                if (TradeInTextBox.Text == "")
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
    }
}
