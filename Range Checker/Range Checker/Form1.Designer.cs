namespace Range_Checker
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
            this.lblrangeapp = new System.Windows.Forms.Label();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.lblrange = new System.Windows.Forms.Label();
            this.lbldecision = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblrangeapp
            // 
            this.lblrangeapp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrangeapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblrangeapp.Location = new System.Drawing.Point(33, 25);
            this.lblrangeapp.Name = "lblrangeapp";
            this.lblrangeapp.Size = new System.Drawing.Size(680, 397);
            this.lblrangeapp.TabIndex = 0;
            this.lblrangeapp.Text = "Range Checker Application";
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldisplay.Location = new System.Drawing.Point(136, 242);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(363, 50);
            this.lbldisplay.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btncalculate.Location = new System.Drawing.Point(72, 313);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(197, 92);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "Check Qualification";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtnumber.Location = new System.Drawing.Point(143, 124);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(242, 45);
            this.txtnumber.TabIndex = 3;
            // 
            // lblrange
            // 
            this.lblrange.AutoSize = true;
            this.lblrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblrange.Location = new System.Drawing.Point(66, 77);
            this.lblrange.Name = "lblrange";
            this.lblrange.Size = new System.Drawing.Size(578, 32);
            this.lblrange.TabIndex = 4;
            this.lblrange.Text = "Enter an integer in the range through 1 to 10:";
            // 
            // lbldecision
            // 
            this.lbldecision.AutoSize = true;
            this.lbldecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbldecision.Location = new System.Drawing.Point(66, 188);
            this.lbldecision.Name = "lbldecision";
            this.lbldecision.Size = new System.Drawing.Size(215, 32);
            this.lbldecision.TabIndex = 5;
            this.lbldecision.Text = "Range Decision";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnclear.Location = new System.Drawing.Point(290, 313);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(149, 43);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnexit.Location = new System.Drawing.Point(290, 362);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(149, 43);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.UseWaitCursor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbldecision);
            this.Controls.Add(this.lblrange);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.lblrangeapp);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrangeapp;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label lblrange;
        private System.Windows.Forms.Label lbldecision;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

