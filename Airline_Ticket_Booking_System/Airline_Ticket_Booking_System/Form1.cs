using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grppersonal_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //declaring and initializing variables
                String name =textname.Text;
                int age = 0;
                int numberOfTickets = 0;
                double weight = 0;
                String classType = "";

                //boolean flag
                bool approved = true;

                //creating constant variables
                const double DISCOUNT_3_4 = 0.05;
                const double DISCOUNT_5 = 0.1;
                const double CHILD_DISCOUNT = 0.2;
                const double SENIOR_DISCOUNT = 0.1;
                const double INSURANCE_RATE= 25;
                const double BAGGAGE_ATE = 3;

                //creating variables for calculating
                double ticketPrice = 0;
                double discount = 0;
                double insurance = 0;
                double free = 0; ;
                double overweightbaggage = 0;




                //validating the name input
                if(name == "")
                {
                    MessageBox.Show("please enter passenger name");
                    approved = false;
                  
                }
                if (approved)
                {
                    //validating numeric inputs
                    if (int.TryParse(textage.Text, out age) && int.TryParse(texttickets.Text, out numberOfTickets) && double.TryParse(textweights.Text, out weight))
                    {
                        //validating age
                        if (age >= 1 && age <= 100)
                        {
                            if (age < 12)
                            {
                                discount += CHILD_DISCOUNT;
                            }
                            else if (age >= 60)
                            {
                                discount += SENIOR_DISCOUNT;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Age must be between 1 and 100 years");
                            approved = false;

                        }
                        if (approved)
                        {
                            //validating number of tickets
                            if (numberOfTickets >= 1 && numberOfTickets <= 5)
                            {
                                if (numberOfTickets >= 1 && numberOfTickets <= 2)
                                {
                                    discount += 0;
                                }
                                else if (numberOfTickets >= 3 && numberOfTickets <= 4)
                                {
                                    discount += DISCOUNT_3_4;
                                }
                                else if (numberOfTickets == 5)
                                {
                                    discount += DISCOUNT_5;
                                }


                            }
                            else
                            {
                                MessageBox.Show("Number of tickets must be between 1 and 5 ");
                                approved = false;
                            }
                        }
                        if (approved)
                        {
                            //validating weight
                            if (weight >= 0 && weight <= (50* numberOfTickets))
                            {
                                if (weight  > free)
                                {
                                    free = 20 * numberOfTickets;
                                    overweightbaggage = weight - free;

                                }
                                {
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("Baggage weight can not be negative and can not exceed 50 kg per passenger");
                                approved = false;
                            }
                        }
                        if (approved)
                        {
                            //validating classes
                            if (rdofirst.Checked)
                            {
                                if (age >= 12)
                                {
                                    ticketPrice = 600;
                                    classType = "First class";
                                }
                                else
                                {
                                    MessageBox.Show("Passenger below 12 can nnot book first class");
                                    approved = false;
                                }
                            }
                            else if (rdobusiness.Checked)
                            {
                                classType = "Business class";

                                ticketPrice = 400;
                            }
                            else if (rdonormal.Checked)
                            {
                                classType = "Normal class";
                                ticketPrice = 200;
                            }
                            else
                            {
                                MessageBox.Show("Please select a class");
                                approved = false;
                            }
                        }
                        if (chkoption.Checked) 
                        {
                            insurance = INSURANCE_RATE * numberOfTickets;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid numeric inputs for age,number of tickets and weights");
                        approved = false;
                        
                    }
                }
                if (approved)
                {
                    //calculating
                    double basicTicketcost = ticketPrice * numberOfTickets;
                    double discountamount = basicTicketcost * discount;
                    double weightfee = overweightbaggage * BAGGAGE_ATE;
                    double total = basicTicketcost + weightfee+ insurance - discountamount;
                    //displaying
                    Airline_Booking_Details.Items.Add("Passanger name : " + name);
                    Airline_Booking_Details.Items.Add("Passanger age : " + age);
                    Airline_Booking_Details.Items.Add("Number of tickets : " + numberOfTickets);
                    Airline_Booking_Details.Items.Add("Baggage weight : " + weight);
                    Airline_Booking_Details.Items.Add("Class Type : " + classType);
                    Airline_Booking_Details.Items.Add("Basic Ticket cost  : " + basicTicketcost.ToString("c"));
                    Airline_Booking_Details.Items.Add("Discount   : " + discountamount.ToString("c"));
                    Airline_Booking_Details.Items.Add("Insurance  : " + insurance.ToString("c"));
                    Airline_Booking_Details.Items.Add("Baggage fee   : " + weightfee.ToString("c"));
                    Airline_Booking_Details.Items.Add("Total Bill : " + total.ToString("c"));
                    Airline_Booking_Details.Items.Add("Booking status  :  Approved");

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
            textname.Clear();
            textage.Clear();
            texttickets.Clear();
            textweights.Clear();
            //clearing radio buttons
            rdobusiness.Checked = false;
            rdofirst.Checked = false;
            rdonormal.Checked = false;
            //clearing check box
            chkoption.Checked = false;
            //clearing list box 
            Airline_Booking_Details.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grptravelclasses_Enter(object sender, EventArgs e)
        {

        }
    }
}
