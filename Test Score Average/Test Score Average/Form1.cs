using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variables 
                double test1, test2, test3, total, avg;
                //creating constant for high score
                const double HIGH_SCORE = 95;
                //inizializing variables
                if (double.TryParse(txtscore1.Text, out test1) &&
                   double.TryParse(txtscore2.Text, out test2) &&
                   double.TryParse(txtscore3.Text, out test3))
                {
                    //calculating total
                    total = test1 + test2 + test3;
                    //calculating avg
                    avg = total / 3.0;
                    //displaying output
                    lbldisplay.Text = avg.ToString("");
                    //using if to validate the score
                    if (avg >= HIGH_SCORE)
                    {
                        MessageBox.Show("Congrats, Your average is higher than 95.");
                    }
                    else if (avg >= 80)
                    {
                        MessageBox.Show("Very Good!");
                    }
                    else if (avg >= 70)
                    {
                        MessageBox.Show("Good!");
                    }
                    else if (avg >= 60)
                    {
                        MessageBox.Show("Passed!");
                    }
                    else
                    {
                        MessageBox.Show("YOU FAILED!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //input clearing
            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();

            //display clearing
            lbldisplay.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}