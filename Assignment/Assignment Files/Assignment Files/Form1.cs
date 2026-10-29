using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create the file
            StreamWriter write;
            write = File.CreateText("students.txt");

            // Write data
            write.WriteLine("Welcome To C# language");
            write.WriteLine("CA242");
            write.WriteLine("Mira Abdalla");

            // Close the file
            write.Close();

            MessageBox.Show("File Created Successfully");
        }

        private void btnCreatePath_Click(object sender, EventArgs e)
        {
            // Create the file using path
            StreamWriter write;

            write = File.CreateText(@"C:\Users\Public\students.txt");

            // Write data
            write.WriteLine("Welcome To C# language");
            write.WriteLine("CA242");
            write.WriteLine("Mira Abdalla");

            // Close the file
            write.Close();

            MessageBox.Show("File Created Successfully");
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            // Open the file
            StreamWriter write;
            write = File.AppendText("students.txt");

            // Add new data
            write.WriteLine("Mira");
            write.WriteLine("Fatima");

            // Close the file
            write.Close();

            MessageBox.Show("Added  Successfully");
        }

        private void btnReadLine_Click(object sender, EventArgs e)
        {
            // Open the file
            StreamReader read;
            read = File.OpenText("students.txt");

            // Read the file
            string line;

            while (read.EndOfStream == false)
            {
                line = read.ReadLine();
                listboxResult.Items.Add(line);
            }

            // Close the file
            read.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Open the file
            StreamReader read;
            read = File.OpenText("students.txt");

            // Read one character
            char letter;
            letter = (char)read.Read();

            // Display
            listboxResult.Items.Add(letter);

            // Close the file
            read.Close();
        }

        private void btnReadToEnd_Click(object sender, EventArgs e)
        {
            // Open the file
            StreamReader read;
            read = File.OpenText("students.txt");

            // Read all text
            string lines;
            lines = read.ReadToEnd();

            // Display
            listboxResult.Items.Add(lines);

            // Close the file
            read.Close();
        }

        private void btnReadAllLines_Click(object sender, EventArgs e)
        {
            // Read all lines
            string[] lines;

            lines = File.ReadAllLines("students.txt");

            // Display the lines
            foreach (string line in lines)
            {
                listboxResult.Items.Add(line);
            }
        }

        private void btnReadAllText_Click(object sender, EventArgs e)
        {
            // Read all text
            string text;

            text = File.ReadAllText("students.txt");

            // Display
            listboxResult.Items.Add(text);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            // Check if the file exists
            if (File.Exists("students.txt"))
            {
                MessageBox.Show("File Exists");
            }
            else
            {
                MessageBox.Show("File Does Not Exist");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the file exists
            if (File.Exists("students.txt"))
            {
                File.Delete("students.txt");

                listboxResult.Items.Clear();

                MessageBox.Show("File Deleted");
            }
            else
            {
                MessageBox.Show("File Does Not Exist");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // Check selected item
            if (listboxResult.SelectedIndex != -1)
            {
                listboxResult.Items.RemoveAt(listboxResult.SelectedIndex);

                MessageBox.Show("Item Removed");
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }
    }
}
