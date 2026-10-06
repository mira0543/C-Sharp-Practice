namespace Pyroll_With_Overtime
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
            this.lblhours = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txthoursworked = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.txthourlypay = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblhours.Location = new System.Drawing.Point(43, 60);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(232, 37);
            this.lblhours.TabIndex = 0;
            this.lblhours.Text = "Hours Worked:";
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btncalculate.Location = new System.Drawing.Point(50, 307);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(210, 73);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate Gross Pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txthoursworked
            // 
            this.txthoursworked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txthoursworked.Location = new System.Drawing.Point(360, 60);
            this.txthoursworked.Multiline = true;
            this.txthoursworked.Name = "txthoursworked";
            this.txthoursworked.Size = new System.Drawing.Size(287, 49);
            this.txthoursworked.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hourly Pay Rate:";
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.AutoSize = true;
            this.lblgrosspay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblgrosspay.Location = new System.Drawing.Point(100, 214);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(175, 37);
            this.lblgrosspay.TabIndex = 4;
            this.lblgrosspay.Text = "Gross Pay:";
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.SystemColors.Window;
            this.lbldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbldisplay.Location = new System.Drawing.Point(360, 214);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(287, 46);
            this.lbldisplay.TabIndex = 5;
            // 
            // txthourlypay
            // 
            this.txthourlypay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txthourlypay.Location = new System.Drawing.Point(360, 133);
            this.txthourlypay.Multiline = true;
            this.txthourlypay.Name = "txthourlypay";
            this.txthourlypay.Size = new System.Drawing.Size(287, 49);
            this.txthourlypay.TabIndex = 6;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnclear.Location = new System.Drawing.Point(293, 307);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(171, 73);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnexit.Location = new System.Drawing.Point(491, 307);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(156, 73);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(683, 439);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txthourlypay);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.lblgrosspay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthoursworked);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblhours);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txthoursworked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.TextBox txthourlypay;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

