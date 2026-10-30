using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viechal_Rental_Management_System
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // 1. Get customer name
            string customerName = txtname.Text.Trim();

            if (customerName == "")
            {
                MessageBox.Show("Customer name cannot be empty.");
                return;
            }

            // 2. Validate customer age
            int customerAge;

            if (!int.TryParse(txtage.Text, out customerAge))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            else if (customerAge < 18 || customerAge > 80)
            {
                MessageBox.Show("Age must be between 18 and 80.");
                return;
            }

            // 3. Validate rental days
            int rentalDays;

            if (!int.TryParse(txtdays.Text, out rentalDays))
            {
                MessageBox.Show("Please enter valid rental days.");
                return;
            }
            else if (rentalDays < 1 || rentalDays > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.");
                return;
            }

            // 4. Validate driving experience
            int drivingExp;

            if (!int.TryParse(txtexperience.Text, out drivingExp))
            {
                MessageBox.Show("Please enter valid driving experience.");
                return;
            }
            else if (drivingExp < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.");
                return;
            }

            // 5. Check vehicle selection
            if (!rdoeconomy.Checked &&
                !rdosuv.Checked &&
                !rdoluxury.Checked)
            {
                MessageBox.Show("Please select a vehicle type.");
                return;
            }

            // 6. Check rental eligibility
            bool isEligible = true;
            string reason = "";

            if (customerAge < 21)
            {
                isEligible = false;
                reason = "Customers must be at least 21 years old.";
            }
            else if (drivingExp < 1)
            {
                isEligible = false;
                reason = "At least 1 year of driving experience is required.";
            }
            else if (rdoluxury.Checked &&
                     (customerAge < 25 || drivingExp < 3))
            {
                isEligible = false;
                reason = "Luxury vehicles require age 25 or above and 3 years of driving experience.";
            }

            if (isEligible == false)
            {
                lstresults.Items.Add("Rental Status: REJECTED");
                lstresults.Items.Add("Reason: " + reason);
                return;
            }

            // 7. Set vehicle rates
            const double ECONOMY_RATE = 35;
            const double SUV_RATE = 60;
            const double LUXURY_RATE = 100;
            const double INSURANCE_RATE = 15;

            double dailyRate = 0;
            string vehicleType = "";

            if (rdoeconomy.Checked)
            {
                dailyRate = ECONOMY_RATE;
                vehicleType = "Economy";
            }
            else if (rdosuv.Checked)
            {
                dailyRate = SUV_RATE;
                vehicleType = "SUV";
            }
            else if (rdoluxury.Checked)
            {
                dailyRate = LUXURY_RATE;
                vehicleType = "Luxury";
            }

            // 8. Calculate basic rental cost
            double basicRentalCost = dailyRate * rentalDays;

            // 9. Calculate discount
            double discountPercent = 0;

            if (rentalDays >= 7 && rentalDays <= 13)
            {
                discountPercent = 0.05;
            }
            else if (rentalDays >= 14)
            {
                discountPercent = 0.10;
            }

            double discountAmount = basicRentalCost * discountPercent;
            double subtotal = basicRentalCost - discountAmount;

            // 10. Calculate insurance
            double insuranceCost = 0;

            if (chkinsurance.Checked)
            {
                insuranceCost = INSURANCE_RATE * rentalDays;
            }

            // 11. Calculate young driver surcharge
            double youngDriverSurcharge = 0;

            if (customerAge >= 21 && customerAge <= 24)
            {
                youngDriverSurcharge = subtotal * 0.10;
            }

            // 12. Calculate final cost
            double finalRentalCost =
                subtotal + insuranceCost + youngDriverSurcharge;

            // 13. Display results
            lstresults.Items.Add("RENTAL DETAILS");
            lstresults.Items.Add("================================");

            lstresults.Items.Add("Customer Name: " + customerName);
            lstresults.Items.Add("Customer Age: " + customerAge.ToString());
            lstresults.Items.Add("Driving Experience: " +
                                 drivingExp.ToString() + " years");
            lstresults.Items.Add("Vehicle Type: " + vehicleType);
            lstresults.Items.Add("Daily Rate: " + dailyRate.ToString("C"));
            lstresults.Items.Add("Rental Days: " + rentalDays.ToString());
            lstresults.Items.Add("Basic Rental Cost: " +
                                 basicRentalCost.ToString("C"));

            if (discountAmount > 0)
            {
                lstresults.Items.Add("Discount: -" +
                                     discountAmount.ToString("C"));
            }

            if (insuranceCost > 0)
            {
                lstresults.Items.Add("Insurance Cost: +" +
                                     insuranceCost.ToString("C"));
            }

            if (youngDriverSurcharge > 0)
            {
                lstresults.Items.Add("Young Driver Surcharge: +" +
                                     youngDriverSurcharge.ToString("C"));
            }

            lstresults.Items.Add("--------------------------------");
            lstresults.Items.Add("Final Rental Cost: " +
                                 finalRentalCost.ToString("C"));
            lstresults.Items.Add("================================");
            lstresults.Items.Add("Rental Status: APPROVED");
        
        
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtdays.Clear();
            txtexperience.Clear();

            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;

            chkinsurance.Checked = false;
            lstresults.Items.Clear();

            txtname.Focus();
        }
    }
}
