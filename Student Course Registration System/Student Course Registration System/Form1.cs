using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Student_Course_Registration_System
{
    public partial class Form1 : Form

    {
        decimal price1 = 0m;
        decimal price2 = 0m;
        decimal price3 = 0m;
        decimal price4 = 0m;
        decimal price5 = 0m;

        int numCourses = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                //creating varables
                String courseName = txtcourseName.Text;
                decimal coursePrice = 0m;
                Boolean approved = true;
                //validating name
                if (courseName == "")
                {
                    MessageBox.Show("Please enter the course  name ");
                    approved = false;
                }
                //validating course price
                if (approved)
                {
                    if (decimal.TryParse(txtprice.Text, out coursePrice))
                    {
                        if (coursePrice <= 0)
                        {
                            MessageBox.Show("Course price must be greater than 0");
                            approved = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Course Price must be decimal input");
                        approved = false;
                    }
                }
                if (approved)
                {
                    //validating maximum course 
                    if (numCourses < 5)
                    {
                        if (numCourses == 0)
                        {
                            price1 = coursePrice;
                        }
                        else if (numCourses == 1)
                        {
                            price2 = coursePrice;
                        }
                        else if (numCourses == 2)
                        {
                            price3 = coursePrice;
                        }
                        else if (numCourses == 3)
                        {
                            price4 = coursePrice;
                        }
                        else if (numCourses == 4)
                        {
                            price5 = coursePrice;
                        }
                        listdisplayregistration.Items.Add("Course Name : " + courseName + "  Course Price : " + coursePrice);
                        numCourses++;
                        txtnumof_corse.Text = numCourses.ToString();

                        txtcourseName.Clear();
                        txtprice.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Number of courses can not be greater than 5 courses");
                        approved = false;
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                //checking selected course 
                int selected = listdisplayregistration.SelectedIndex;
                if (selected != -1)
                {
                    listdisplayregistration.Items.RemoveAt(selected);
                    if (selected == 0)
                    {
                        price1 = price2;
                        price2 = price3;
                        price3 = price4;
                        price5 = 0m;
                    }
                    else if (selected == 1)
                    {
                        price2 = price3;
                        price3 = price4;
                        price4 = price5;
                        price5 = 0m;
                    }
                    else if (selected == 2)
                    {
                        price3 = price4;
                        price4 = price5;
                        price5 = 0m;
                    }
                    else if (selected == 3)
                    {
                        price4 = price5;
                        price5 = 0m;
                    }
                    else if (selected == 4)
                    {
                        price5 = 0m;
                    }

                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Please select item ");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {

                //creating variables
                String courseName = txtcourseName.Text;
                decimal coursePrice = 0m;
                String name = txtname.Text;
                String id = txtid.Text;
                //declaring numeric variable
                int age;
                int count = 0;
                int actualCourses = 0;
                decimal discount = 0m;
                decimal basicfee = 0m;
                decimal total = 0m;
                decimal discountAmount = 0;
                Boolean approved = true;
                // validating name and  id 
                if (name == "" || id == "")
                {
                    MessageBox.Show("Name And Id can not be empty please enter");
                    approved = false;
                }
                if (approved)
                {
                    //validating numeric input
                    if (int.TryParse(txtage.Text, out age))
                    {
                        //validating age
                        if (age >= 16 && age <= 60)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Student age must be between 16 and 60");
                            approved = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("age input must be integer");
                        approved = false;
                    }
                }

                //validating price
                if (approved)
                {
                    while (count < 5)
                    {
                        if (count == 0 && price1 > 0)
                        {
                            basicfee += price1;
                            actualCourses++;
                        }
                        else if (count == 1 && price2 > 0)
                        {
                            basicfee += price2;
                            actualCourses++;
                        }
                        else if (count == 2 && price3 > 0)
                        {
                            basicfee += price3;
                            actualCourses++;
                        }
                        else if (count == 3 && price4 > 0)
                        {
                            basicfee += price4;
                            actualCourses++;
                        }
                        else if (count == 4 && price5 > 0)
                        {
                            basicfee += price5;
                            actualCourses++;
                        }
                        count++;
                    }
                    //checking one course registration
                    if (actualCourses == 0)
                    {
                        MessageBox.Show("One course should be registred at least ");
                    }


                }
                if (approved)
                {
                    // validating discount
                    if (actualCourses == 1)
                    {
                        discount = 0;
                    }
                    else if (actualCourses == 2)
                    {
                        discount = 0.05m;
                    }
                    else if (actualCourses == 3 || actualCourses == 4)
                    {
                        discount = 0.1m;
                    }
                    else if (actualCourses == 5)
                    {
                        discount = 0.15m;
                    }
                    discountAmount = basicfee * discount;
                    total = basicfee - discountAmount;

                    listdisplayresult.Items.Add("Student Registration Result");
                    listdisplayresult.Items.Add("------------------------------------");
                    listdisplayresult.Items.Add("Student Name : " + name);
                    listdisplayresult.Items.Add("Student ID : " + id);
                    listdisplayresult.Items.Add("Number of courses: " + actualCourses);
                    listdisplayresult.Items.Add("Basic Registration Fee: " + basicfee.ToString("C"));
                    listdisplayresult.Items.Add("course Discount : " + discountAmount.ToString("C"));
                    listdisplayresult.Items.Add("Final Registration Fee: " + total.ToString("C"));
                    listdisplayresult.Items.Add(" Registration Status: Approved ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text box
            txtname.Clear();
            txtid.Clear();
            txtage.Clear();
            txtcourseName.Clear();
            txtprice.Clear();
            txtnumof_corse.Clear();
            //clearing lis boxes
            listdisplayregistration.Items.Clear();
            listdisplayresult.Items.Clear();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //closing 
            this.Close();
        }

        private void btnaddcourse_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}