using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void btncalculate_Click(object sender, EventArgs e)
        {
            //declaring variable
            double weight =0; 
            double height= 0;
            double BMI = 0;
            //int count = 0;
            String Wcategory = "";
            //input validation
            if (double.TryParse(txtweight.Text, out weight) && double.TryParse(txtheight.Text, out height))
            {
                //calculating
                BMI = weight / (height * height);
                if(weight>0 && height>0)
                {
                    if(BMI < 18.5)
                    {
                        Wcategory = "Uderweight";
                    }
                    else if(BMI > 18.5 && BMI < 25)
                    {
                        Wcategory = "Optimal Weight";
                    }
                    else if(BMI > 25)
                    {
                        Wcategory = "Overweight";
                    }

                }
                else
                {
                    MessageBox.Show("Invalid input,Weight and Height must be positive value");
                }


            }
            else
            {
                MessageBox.Show("Invalid innput, Please input numeric value");
            }

            //displaying result
            displayListbox.Items.Add("Weight: " + weight);
            displayListbox.Items.Add("Height: " + height);
            displayListbox.Items.Add("BMI: " + BMI.ToString("f2"));
            displayListbox.Items.Add("Category: " + Wcategory);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            //clearing textbox
            txtheight.Clear();
            txtweight.Clear();

            //clearing listbox
            displayListbox.Items.Clear();
        }
    }
}
