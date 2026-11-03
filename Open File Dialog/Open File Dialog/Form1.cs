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

namespace Open_File_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //import file
            StreamReader reader;

            DialogResult result;
            result = OpenFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                reader = File.OpenText(OpenFile.FileName);

                string line;
                while (reader.EndOfStream == false)
                {
                    line = reader.ReadLine();
                    listResult.Items.Add(line);
                }
                reader.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("not open the file");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            DialogResult dialog;
            dialog = SaveFile.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                writer = File.AppendText(SaveFile.FileName);

                writer.WriteLine(txtInput.Text);
                writer.Close();
            }
            else if (dialog == DialogResult.Cancel)
            {
                MessageBox.Show("not save the file");
            }
        }
    }
    
}
