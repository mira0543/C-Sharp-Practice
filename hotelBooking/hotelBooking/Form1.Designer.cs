namespace hotelBooking
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
            this.hotelbookinglbl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lbldisplay1 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtPriceNights = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbldisplay2 = new System.Windows.Forms.Label();
            this.lbldisplay3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hotelbookinglbl
            // 
            this.hotelbookinglbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.hotelbookinglbl.AutoSize = true;
            this.hotelbookinglbl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hotelbookinglbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.hotelbookinglbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hotelbookinglbl.Location = new System.Drawing.Point(147, 18);
            this.hotelbookinglbl.Name = "hotelbookinglbl";
            this.hotelbookinglbl.Size = new System.Drawing.Size(598, 47);
            this.hotelbookinglbl.TabIndex = 0;
            this.hotelbookinglbl.Text = "Hotel Room Booking Calculator";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(291, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter Guest Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Room Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(41, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Number Of Nights:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(41, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Price Per Night";
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.AutoSize = true;
            this.lblServiceTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTax.Location = new System.Drawing.Point(23, 483);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(293, 37);
            this.lblServiceTax.TabIndex = 5;
            this.lblServiceTax.Text = "Service Tax(10%):";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(23, 554);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(360, 37);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "Discount Amount(5%):";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(23, 617);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(232, 37);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lbldisplay1
            // 
            this.lbldisplay1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbldisplay1.Location = new System.Drawing.Point(383, 475);
            this.lbldisplay1.Name = "lbldisplay1";
            this.lbldisplay1.Size = new System.Drawing.Size(528, 50);
            this.lbldisplay1.TabIndex = 8;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtGuestName.Location = new System.Drawing.Point(515, 94);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(396, 49);
            this.txtGuestName.TabIndex = 11;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRoomType.Location = new System.Drawing.Point(515, 157);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(396, 49);
            this.txtRoomType.TabIndex = 12;
            // 
            // txtNights
            // 
            this.txtNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNights.Location = new System.Drawing.Point(515, 227);
            this.txtNights.Multiline = true;
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(396, 49);
            this.txtNights.TabIndex = 13;
            // 
            // txtPriceNights
            // 
            this.txtPriceNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPriceNights.Location = new System.Drawing.Point(515, 294);
            this.txtPriceNights.Multiline = true;
            this.txtPriceNights.Name = "txtPriceNights";
            this.txtPriceNights.Size = new System.Drawing.Size(396, 49);
            this.txtPriceNights.TabIndex = 14;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculate.Location = new System.Drawing.Point(48, 363);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(227, 59);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.Location = new System.Drawing.Point(367, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(227, 59);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.Location = new System.Drawing.Point(668, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 59);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbldisplay2
            // 
            this.lbldisplay2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbldisplay2.Location = new System.Drawing.Point(383, 548);
            this.lbldisplay2.Name = "lbldisplay2";
            this.lbldisplay2.Size = new System.Drawing.Size(528, 50);
            this.lbldisplay2.TabIndex = 18;
            // 
            // lbldisplay3
            // 
            this.lbldisplay3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldisplay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbldisplay3.Location = new System.Drawing.Point(383, 620);
            this.lbldisplay3.Name = "lbldisplay3";
            this.lbldisplay3.Size = new System.Drawing.Size(528, 50);
            this.lbldisplay3.TabIndex = 19;
            this.lbldisplay3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 707);
            this.Controls.Add(this.lbldisplay3);
            this.Controls.Add(this.lbldisplay2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPriceNights);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lbldisplay1);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.hotelbookinglbl);
            this.Name = "Form1";
            this.Text = "Hotel Booking Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hotelbookinglbl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblServiceTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lbldisplay1;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtPriceNights;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbldisplay2;
        private System.Windows.Forms.Label lbldisplay3;
    }
}

