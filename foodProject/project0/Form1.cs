using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            
            //creating variables
            String food1, food2;
            double total1, total2;
            double price1, price2;
            //creating constant variable
            double TAX = 0.07;
            
            try
            {
                //initializing variables
                food1 = txtfood1.Text;
                food2 = txtfood2.Text;
                price1 = double.Parse(txtprice1.Text);
                price2 = double.Parse(txtprice2.Text);

                //calculating
                total1 = (price1 + price2) * TAX;
                total2 = price2 + total1;
                //displaying results
                lbldisplay1.Text = total1.ToString();
                lbldisplay2.Text = total2.ToString();
            }
            catch {
                MessageBox.Show("Invalid input");
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //textbox clearing
            txtfood1.Clear();
            txtfood2.Clear();
            txtprice1.Clear();
            txtprice2.Clear();

            //lbl clearing
            lbldisplay1.Text = "";
            lbldisplay2.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
