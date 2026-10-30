namespace Hotel__Rom_Booking_System
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
            this.displaylistbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.chboxoption = new System.Windows.Forms.CheckBox();
            this.rdbtnstandard = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbtnhigh = new System.Windows.Forms.RadioButton();
            this.rdbtnnormal = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtguests = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(871, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Room Booling System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displaylistbox
            // 
            this.displaylistbox.FormattingEnabled = true;
            this.displaylistbox.ItemHeight = 20;
            this.displaylistbox.Items.AddRange(new object[] {
            "BOOKING DETAILS"});
            this.displaylistbox.Location = new System.Drawing.Point(512, 61);
            this.displaylistbox.Name = "displaylistbox";
            this.displaylistbox.Size = new System.Drawing.Size(345, 424);
            this.displaylistbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 176);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personal Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btncalculate.Location = new System.Drawing.Point(3, 435);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(153, 50);
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnclear.Location = new System.Drawing.Point(171, 435);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(150, 50);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnexit.Location = new System.Drawing.Point(345, 435);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(156, 50);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Guest Name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(192, 92);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(243, 28);
            this.txtname.TabIndex = 9;
            // 
            // chboxoption
            // 
            this.chboxoption.AutoSize = true;
            this.chboxoption.Location = new System.Drawing.Point(12, 388);
            this.chboxoption.Name = "chboxoption";
            this.chboxoption.Size = new System.Drawing.Size(267, 24);
            this.chboxoption.TabIndex = 10;
            this.chboxoption.Text = "BreakFast(10 per guest per night)";
            this.chboxoption.UseVisualStyleBackColor = true;
            // 
            // rdbtnstandard
            // 
            this.rdbtnstandard.AutoSize = true;
            this.rdbtnstandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rdbtnstandard.Location = new System.Drawing.Point(12, 291);
            this.rdbtnstandard.Name = "rdbtnstandard";
            this.rdbtnstandard.Size = new System.Drawing.Size(103, 28);
            this.rdbtnstandard.TabIndex = 11;
            this.rdbtnstandard.TabStop = true;
            this.rdbtnstandard.Text = "Standard";
            this.rdbtnstandard.UseVisualStyleBackColor = true;
            this.rdbtnstandard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(498, 78);
            this.label4.TabIndex = 12;
            this.label4.Text = "Personal Information";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(498, 78);
            this.label5.TabIndex = 13;
            this.label5.Text = "Personal Information";
            // 
            // rdbtnhigh
            // 
            this.rdbtnhigh.AutoSize = true;
            this.rdbtnhigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rdbtnhigh.Location = new System.Drawing.Point(358, 291);
            this.rdbtnhigh.Name = "rdbtnhigh";
            this.rdbtnhigh.Size = new System.Drawing.Size(68, 28);
            this.rdbtnhigh.TabIndex = 14;
            this.rdbtnhigh.TabStop = true;
            this.rdbtnhigh.Text = "High";
            this.rdbtnhigh.UseVisualStyleBackColor = true;
            // 
            // rdbtnnormal
            // 
            this.rdbtnnormal.AutoSize = true;
            this.rdbtnnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rdbtnnormal.Location = new System.Drawing.Point(171, 291);
            this.rdbtnnormal.Name = "rdbtnnormal";
            this.rdbtnnormal.Size = new System.Drawing.Size(89, 28);
            this.rdbtnnormal.TabIndex = 15;
            this.rdbtnnormal.TabStop = true;
            this.rdbtnnormal.Text = "Normal";
            this.rdbtnnormal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of guests:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Number of Nights:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Guest Age:";
            // 
            // txtguests
            // 
            this.txtguests.Location = new System.Drawing.Point(192, 194);
            this.txtguests.Multiline = true;
            this.txtguests.Name = "txtguests";
            this.txtguests.Size = new System.Drawing.Size(243, 28);
            this.txtguests.TabIndex = 19;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(192, 160);
            this.txtnights.Multiline = true;
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(243, 28);
            this.txtnights.TabIndex = 20;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(192, 126);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(243, 28);
            this.txtage.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 508);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtnights);
            this.Controls.Add(this.txtguests);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbtnnormal);
            this.Controls.Add(this.rdbtnhigh);
            this.Controls.Add(this.rdbtnstandard);
            this.Controls.Add(this.chboxoption);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.displaylistbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox displaylistbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.CheckBox chboxoption;
        private System.Windows.Forms.RadioButton rdbtnstandard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbtnhigh;
        private System.Windows.Forms.RadioButton rdbtnnormal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtguests;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtage;
    }
}

