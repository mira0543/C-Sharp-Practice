namespace Airline_Ticket_Booking_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalculate = new System.Windows.Forms.Button();
            this.chkoption = new System.Windows.Forms.CheckBox();
            this.Airline_Booking_Details = new System.Windows.Forms.ListBox();
            this.rdofirst = new System.Windows.Forms.RadioButton();
            this.textname = new System.Windows.Forms.TextBox();
            this.grppersonal = new System.Windows.Forms.GroupBox();
            this.textweights = new System.Windows.Forms.TextBox();
            this.texttickets = new System.Windows.Forms.TextBox();
            this.textage = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.lbltickets = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.grptravelclasses = new System.Windows.Forms.GroupBox();
            this.rdobusiness = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.grpoption = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.grppersonal.SuspendLayout();
            this.grptravelclasses.SuspendLayout();
            this.grpoption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btncalculate.Location = new System.Drawing.Point(17, 513);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(192, 69);
            this.btncalculate.TabIndex = 0;
            this.btncalculate.Text = "Ca&lculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // chkoption
            // 
            this.chkoption.AutoSize = true;
            this.chkoption.Location = new System.Drawing.Point(40, 41);
            this.chkoption.Name = "chkoption";
            this.chkoption.Size = new System.Drawing.Size(468, 33);
            this.chkoption.TabIndex = 1;
            this.chkoption.Text = "Add Travel Insurance ($25 per ticket)";
            this.chkoption.UseVisualStyleBackColor = true;
            // 
            // Airline_Booking_Details
            // 
            this.Airline_Booking_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airline_Booking_Details.FormattingEnabled = true;
            this.Airline_Booking_Details.ItemHeight = 25;
            this.Airline_Booking_Details.Location = new System.Drawing.Point(658, 84);
            this.Airline_Booking_Details.Name = "Airline_Booking_Details";
            this.Airline_Booking_Details.Size = new System.Drawing.Size(424, 529);
            this.Airline_Booking_Details.TabIndex = 2;
            this.Airline_Booking_Details.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rdofirst
            // 
            this.rdofirst.AutoSize = true;
            this.rdofirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.rdofirst.Location = new System.Drawing.Point(27, 47);
            this.rdofirst.Name = "rdofirst";
            this.rdofirst.Size = new System.Drawing.Size(151, 30);
            this.rdofirst.TabIndex = 3;
            this.rdofirst.TabStop = true;
            this.rdofirst.Text = "First Class";
            this.rdofirst.UseVisualStyleBackColor = true;
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(279, 39);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(314, 30);
            this.textname.TabIndex = 4;
            // 
            // grppersonal
            // 
            this.grppersonal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grppersonal.Controls.Add(this.textweights);
            this.grppersonal.Controls.Add(this.texttickets);
            this.grppersonal.Controls.Add(this.textage);
            this.grppersonal.Controls.Add(this.lblweight);
            this.grppersonal.Controls.Add(this.lbltickets);
            this.grppersonal.Controls.Add(this.lblage);
            this.grppersonal.Controls.Add(this.lblname);
            this.grppersonal.Controls.Add(this.textname);
            this.grppersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grppersonal.Location = new System.Drawing.Point(12, 84);
            this.grppersonal.Name = "grppersonal";
            this.grppersonal.Size = new System.Drawing.Size(624, 191);
            this.grppersonal.TabIndex = 5;
            this.grppersonal.TabStop = false;
            this.grppersonal.Text = "Personal Information";
            this.grppersonal.Enter += new System.EventHandler(this.grppersonal_Enter);
            // 
            // textweights
            // 
            this.textweights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textweights.Location = new System.Drawing.Point(279, 147);
            this.textweights.Name = "textweights";
            this.textweights.Size = new System.Drawing.Size(314, 30);
            this.textweights.TabIndex = 14;
            // 
            // texttickets
            // 
            this.texttickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttickets.Location = new System.Drawing.Point(279, 111);
            this.texttickets.Name = "texttickets";
            this.texttickets.Size = new System.Drawing.Size(314, 30);
            this.texttickets.TabIndex = 13;
            // 
            // textage
            // 
            this.textage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textage.Location = new System.Drawing.Point(279, 75);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(314, 30);
            this.textage.TabIndex = 12;
            // 
            // lblweight
            // 
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblweight.Location = new System.Drawing.Point(20, 140);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(286, 28);
            this.lblweight.TabIndex = 11;
            this.lblweight.Text = "Baggage Weight(kg) :";
            // 
            // lbltickets
            // 
            this.lbltickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbltickets.Location = new System.Drawing.Point(20, 105);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(286, 28);
            this.lbltickets.TabIndex = 10;
            this.lbltickets.Text = "Number Of Tickets : ";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblage.Location = new System.Drawing.Point(20, 76);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(185, 25);
            this.lblage.TabIndex = 9;
            this.lblage.Text = "Passenger Age  : ";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(20, 41);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(230, 28);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Passenger Name : ";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-2, 2);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(1101, 62);
            this.lbltitle.TabIndex = 6;
            this.lbltitle.Text = "Airline Ticket Booking system\r\n";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grptravelclasses
            // 
            this.grptravelclasses.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grptravelclasses.Controls.Add(this.rdobusiness);
            this.grptravelclasses.Controls.Add(this.rdonormal);
            this.grptravelclasses.Controls.Add(this.rdofirst);
            this.grptravelclasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptravelclasses.Location = new System.Drawing.Point(12, 287);
            this.grptravelclasses.Name = "grptravelclasses";
            this.grptravelclasses.Size = new System.Drawing.Size(624, 100);
            this.grptravelclasses.TabIndex = 6;
            this.grptravelclasses.TabStop = false;
            this.grptravelclasses.Text = "Travel Classes";
            this.grptravelclasses.Enter += new System.EventHandler(this.grptravelclasses_Enter);
            // 
            // rdobusiness
            // 
            this.rdobusiness.AutoSize = true;
            this.rdobusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.rdobusiness.Location = new System.Drawing.Point(388, 47);
            this.rdobusiness.Name = "rdobusiness";
            this.rdobusiness.Size = new System.Drawing.Size(201, 30);
            this.rdobusiness.TabIndex = 5;
            this.rdobusiness.TabStop = true;
            this.rdobusiness.Text = "Business Class";
            this.rdobusiness.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.rdonormal.Location = new System.Drawing.Point(186, 47);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(181, 30);
            this.rdonormal.TabIndex = 4;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Normal Class";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // grpoption
            // 
            this.grpoption.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpoption.Controls.Add(this.chkoption);
            this.grpoption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpoption.Location = new System.Drawing.Point(12, 398);
            this.grpoption.Name = "grpoption";
            this.grpoption.Size = new System.Drawing.Size(624, 97);
            this.grpoption.TabIndex = 7;
            this.grpoption.TabStop = false;
            this.grpoption.Text = "Additional Option";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnclear.Location = new System.Drawing.Point(215, 513);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(174, 69);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnexit.Location = new System.Drawing.Point(410, 513);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(173, 69);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1094, 628);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.grpoption);
            this.Controls.Add(this.grptravelclasses);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.grppersonal);
            this.Controls.Add(this.Airline_Booking_Details);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "Airline Ticket Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grppersonal.ResumeLayout(false);
            this.grppersonal.PerformLayout();
            this.grptravelclasses.ResumeLayout(false);
            this.grptravelclasses.PerformLayout();
            this.grpoption.ResumeLayout(false);
            this.grpoption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.CheckBox chkoption;
        private System.Windows.Forms.ListBox Airline_Booking_Details;
        private System.Windows.Forms.RadioButton rdofirst;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.GroupBox grppersonal;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox grptravelclasses;
        private System.Windows.Forms.GroupBox grpoption;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox textweights;
        private System.Windows.Forms.TextBox texttickets;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.RadioButton rdobusiness;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

