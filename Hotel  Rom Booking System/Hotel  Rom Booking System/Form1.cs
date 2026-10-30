using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel__Rom_Booking_System
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variable
                String name = txtname.Text;
                int age, guests;
                int night;

                //validate all numeric input 
                if (!int.TryParse(txtage.Text, out age) || !int.TryParse(txtnights.Text, out night) || !int.TryParse(txtguests.Text, out guests))
                {
                    MessageBox.Show("");
                    displaylistbox.Text = "REJECTED";
                    return;
                }
                //gestname cannot be empty
                if (name == "")
                {
                    MessageBox.Show("name cannot be empty!");
                    displaylistbox.Text = "REJECTED";
                    return;
                }
                //guest age must be between 18 and 90
                if (age < 18 || age > 90)
                {
                    MessageBox.Show("age mmust be between 18 and 90");
                    displaylistbox.Text = "REJECTED";
                    return;
                }
                //number of nights must be 1 - 30
                if (night < 1 || night > 30)
                {
                    MessageBox.Show("");
                    displaylistbox.Text = "REJECTED";
                    return;
                }
                //number of guests must be 1-6
                if (guests < 1 || guests > 6)
                {
                    MessageBox.Show("");
                    displaylistbox.Text = "REJECTED";
                    return;
                }
                //variables
                double rate_per_Night = 0.0;
                String RoomType = "";
                String selectedRoom = "";
                //checkeing
                if (rdbtnstandard.Checked)
                {
                    selectedRoom = "Standard";
                }
                else if (rdbtnnormal.Checked)
                {
                    selectedRoom = "Normal";
                }
                else if (rdbtnhigh.Checked)
                {
                    selectedRoom = "High";
                }
                //switch
                switch (selectedRoom)
                {
                    case "Standard":
                        rate_per_Night = 50.0;
                        RoomType = "Standard";
                        break;

                    case "Normal":
                        rate_per_Night = 80.0;
                        RoomType = "Normal";
                        break;

                    case "High":
                        rate_per_Night = 130.0;
                        RoomType = "High";
                        break;
                    default:
                        MessageBox.Show("Please select a room type.");
                        return;

                }

                // Basic Room Cost
                double basicRoomCost = rate_per_Night * night;

                // 5. Stay Discount 
                double stayDiscount = 0.0;
                if (night >= 10)
                {
                    stayDiscount = basicRoomCost * 0.12;
                }
                else if (night >= 5)
                {
                    stayDiscount = basicRoomCost * 0.05;
                }

                // 6. Senior Discount 
                double seniorDiscount = 0.0;
                if (age >= 60)
                {
                    seniorDiscount = basicRoomCost * 0.05;
                }

                // 7. Breakfast Cost ($10 per guest per night)
                double breakfastCost = 0.0;
                if (chboxoption.Checked)
                {
                    breakfastCost = 10.0 * guests * night;
                }

                // 8. Service Surcharge
                double serviceSurcharge = 0.0;
                if (guests > 4)
                {
                    serviceSurcharge = basicRoomCost * 0.05;
                }
                // 9. Calculate Final Cost
                double finalCost = (basicRoomCost - stayDiscount - seniorDiscount) + breakfastCost + serviceSurcharge;

                // 10. Display Outputs in the ListBox
                displaylistbox.Items.Clear();
                displaylistbox.Items.Add("Booking Details");

                displaylistbox.Items.Add("====================");
                displaylistbox.Items.Add("Guest Name: " + name);
                displaylistbox.Items.Add("Guest Age: " + age);
                displaylistbox.Items.Add("Number of Guests: " + guests);
                displaylistbox.Items.Add("Number of Nights: " + night);
                displaylistbox.Items.Add("Room Type: " + RoomType);
                displaylistbox.Items.Add("Rate Per Night: " + rate_per_Night.ToString("C"));
                displaylistbox.Items.Add("Basic Room Cost: " + basicRoomCost.ToString("C"));
                displaylistbox.Items.Add("Stay Discount: " + stayDiscount.ToString("C"));
                displaylistbox.Items.Add("Senior Discount: " + seniorDiscount.ToString("C"));
                displaylistbox.Items.Add("Breakfast Cost: " + breakfastCost.ToString("C"));
                displaylistbox.Items.Add("Service Surcharge: " + serviceSurcharge.ToString("C"));
                displaylistbox.Items.Add("Final Cost: " + finalCost.ToString("C"));
                displaylistbox.Items.Add("====================");

                // Display booking status in ListBox
                displaylistbox.Items.Add("Booking Status: APPROVED");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }





}

        private void btnclear_Click(object sender, EventArgs e)
        {
            //txtBox clearing
            txtage.Clear();
            txtguests.Clear();  
            txtname.Clear();
            txtnights.Clear();

            //clearing listbox
            displaylistbox.Items.Clear();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
