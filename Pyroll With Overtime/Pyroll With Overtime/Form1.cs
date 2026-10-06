using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyroll_With_Overtime
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
                //creating variables 
                double hoursworked, hourlypay, grosspay;
                //create constant variable
                const double OVERTIME_RATE = 1.5;
                //validation
                if (double.TryParse(txthoursworked.Text, out hoursworked) && hoursworked >= 0)
                {

                    if (double.TryParse(txthourlypay.Text, out hourlypay) && hourlypay >= 0)
                    {
                        //validatng the gross pay 
                        if (hoursworked <= 50)
                        {
                            grosspay = hoursworked * hourlypay;
                        }
                        else
                        {
                            double overtime = hoursworked - 50;
                            grosspay = (50 * hourlypay) + (overtime * hourlypay * OVERTIME_RATE);
                        }
                        //display
                        lbldisplay.Text = grosspay.ToString("C");

                    }
                    else {
                        MessageBox.Show("invalid hourly pay rate");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid hours worked ");
                }
            }
            //defualt message error
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text box
            txthoursworked.Clear();
            txthourlypay.Clear();

            //clearing the display
            lbldisplay.Text = "";
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
