namespace Viechal_Rental_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lstresults = new System.Windows.Forms.ListBox();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1225, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Rental Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(26, 572);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(223, 68);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.Window;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtname.Location = new System.Drawing.Point(406, 115);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(285, 32);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Costumer Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costumer Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Rental Days:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Years of Drving Experience:";
            // 
            // txtdays
            // 
            this.txtdays.BackColor = System.Drawing.SystemColors.Window;
            this.txtdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdays.Location = new System.Drawing.Point(406, 203);
            this.txtdays.Multiline = true;
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(285, 32);
            this.txtdays.TabIndex = 9;
            // 
            // txtexperience
            // 
            this.txtexperience.BackColor = System.Drawing.SystemColors.Window;
            this.txtexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtexperience.Location = new System.Drawing.Point(406, 246);
            this.txtexperience.Multiline = true;
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(285, 32);
            this.txtexperience.TabIndex = 10;
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.SystemColors.Window;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtage.Location = new System.Drawing.Point(406, 159);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(285, 32);
            this.txtage.TabIndex = 11;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(277, 572);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(212, 68);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(524, 572);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(199, 68);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(755, 265);
            this.label8.TabIndex = 16;
            this.label8.Text = "Costumer Information ";
            // 
            // lstresults
            // 
            this.lstresults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstresults.FormattingEnabled = true;
            this.lstresults.ItemHeight = 29;
            this.lstresults.Items.AddRange(new object[] {
            " "});
            this.lstresults.Location = new System.Drawing.Point(763, 62);
            this.lstresults.Name = "lstresults";
            this.lstresults.Size = new System.Drawing.Size(445, 555);
            this.lstresults.TabIndex = 17;
            this.lstresults.Tag = "";
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoeconomy.Location = new System.Drawing.Point(92, 396);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(138, 33);
            this.rdoeconomy.TabIndex = 18;
            this.rdoeconomy.TabStop = true;
            this.rdoeconomy.Text = "Economy";
            this.rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkinsurance.Location = new System.Drawing.Point(94, 515);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(339, 33);
            this.chkinsurance.TabIndex = 19;
            this.chkinsurance.Text = "Add insurance ($15 per day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdosuv.Location = new System.Drawing.Point(293, 395);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(86, 33);
            this.rdosuv.TabIndex = 20;
            this.rdosuv.TabStop = true;
            this.rdosuv.Text = "SUV";
            this.rdosuv.UseVisualStyleBackColor = true;
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoluxury.Location = new System.Drawing.Point(436, 396);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(107, 33);
            this.rdoluxury.TabIndex = 21;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(2, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(755, 102);
            this.label9.TabIndex = 22;
            this.label9.Text = "Vehicle Type:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(2, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(755, 105);
            this.label6.TabIndex = 23;
            this.label6.Text = "Insurance Option:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 650);
            this.Controls.Add(this.rdoluxury);
            this.Controls.Add(this.rdosuv);
            this.Controls.Add(this.chkinsurance);
            this.Controls.Add(this.rdoeconomy);
            this.Controls.Add(this.lstresults);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtexperience);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstresults;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}

