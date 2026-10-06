using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variables
                String name, roomType;
                int nights;
                double price;
                //creating constant variables
                double SERVICE_TAX = 0.1;
                double DISCOUNT = 0.05;

                //intializing variables
                name = txtGuestName.Text;
                roomType = txtRoomType.Text;
                nights = int.Parse(txtNights.Text);
                price = double.Parse(txtPriceNights.Text);

                //calculating
                double amount = price * nights;
                double sTax = amount * SERVICE_TAX;
                double disc = DISCOUNT * amount;
                double total = amount + sTax - disc;

                //displaying results

                lbldisplay1.Text = sTax.ToString("C");
                lbldisplay2.Text = disc.ToString("C");
                lbldisplay3.Text = total.ToString("C");
            }
            catch (Exception ex) {
                MessageBox.Show("Invalid Input,Try Again");
            
            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtRoomType.Clear();
            txtNights.Clear();
            txtPriceNights.Clear();

            //clearing display
            lbldisplay1.Text = "";
            lbldisplay2.Text = "";
            lbldisplay3.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
