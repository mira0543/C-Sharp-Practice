using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            //creating input variables
            string Sname, department, semester;
            int SID;


            //initial values to variables
            Sname = txtname.Text;
            SID = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = txtsemester.Text;

            //process
            String fullinfo;
            fullinfo = "Name :" + Sname + " ID : " + SID +
                "  Department : " + department
                + " semester " + semester;
            // output
            lbloutput.Text = fullinfo;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();

            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
