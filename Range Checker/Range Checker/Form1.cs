using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variable
                int number;
                //validation
                if (int.TryParse(txtnumber.Text,out number))
                {
                    //checking if the number is in the range 
                    if (number >= 1 && number <= 10)
                    {
                        lbldisplay.Text = number.ToString() + " The number is in the range!";
                    }
                    else {
                        lbldisplay.Text = number.ToString() + " The number is not in the range!";
                    
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input!,Please make sure you entered number in the range");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text box
            txtnumber.Clear();

            //clearing the label
            lbldisplay.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
