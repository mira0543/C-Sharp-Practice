using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            //creating variable 
            String dayOf_week, name_of_month, Full_Date;
            int numeric_Day;
            int Year;
            //intiation values variable
            dayOf_week = txtdayOfweek.Text;
            name_of_month = txtmonth.Text;
            numeric_Day = int.Parse(txtdayOfmonth.Text);
            Year = int.Parse(txtyear.Text);

            //concataninate
            Full_Date = dayOf_week + " " + name_of_month + " " + numeric_Day + " " + Year;
            //display the result
            lbldateoutput.Text = Full_Date;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox and label
            txtdayOfweek.Clear();
            txtdayOfmonth.Text = "";
            txtmonth.Text = string.Empty;
            txtyear.Clear();
            //clearing label
            //clearing label - not used clear function
            lbldateoutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
