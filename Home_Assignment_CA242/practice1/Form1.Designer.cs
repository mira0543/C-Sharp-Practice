namespace practice1
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
            this.txtdayOfweek = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdayOfmonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lbldayOfweekprompt = new System.Windows.Forms.Label();
            this.lblmonthprompt = new System.Windows.Forms.Label();
            this.lbldayOfmonthprompt = new System.Windows.Forms.Label();
            this.lblyearprompt = new System.Windows.Forms.Label();
            this.lbldateoutput = new System.Windows.Forms.Label();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdayOfweek
            // 
            this.txtdayOfweek.Location = new System.Drawing.Point(475, 67);
            this.txtdayOfweek.Multiline = true;
            this.txtdayOfweek.Name = "txtdayOfweek";
            this.txtdayOfweek.Size = new System.Drawing.Size(350, 47);
            this.txtdayOfweek.TabIndex = 0;
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(475, 132);
            this.txtmonth.Multiline = true;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(350, 47);
            this.txtmonth.TabIndex = 1;
            // 
            // txtdayOfmonth
            // 
            this.txtdayOfmonth.Location = new System.Drawing.Point(475, 197);
            this.txtdayOfmonth.Multiline = true;
            this.txtdayOfmonth.Name = "txtdayOfmonth";
            this.txtdayOfmonth.Size = new System.Drawing.Size(350, 47);
            this.txtdayOfmonth.TabIndex = 2;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(475, 263);
            this.txtyear.Multiline = true;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(350, 47);
            this.txtyear.TabIndex = 3;
            // 
            // lbldayOfweekprompt
            // 
            this.lbldayOfweekprompt.AutoSize = true;
            this.lbldayOfweekprompt.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayOfweekprompt.Location = new System.Drawing.Point(60, 67);
            this.lbldayOfweekprompt.Name = "lbldayOfweekprompt";
            this.lbldayOfweekprompt.Size = new System.Drawing.Size(339, 34);
            this.lbldayOfweekprompt.TabIndex = 4;
            this.lbldayOfweekprompt.Text = "Enter the day of the week";
            // 
            // lblmonthprompt
            // 
            this.lblmonthprompt.AutoSize = true;
            this.lblmonthprompt.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthprompt.Location = new System.Drawing.Point(54, 132);
            this.lblmonthprompt.Name = "lblmonthprompt";
            this.lblmonthprompt.Size = new System.Drawing.Size(380, 34);
            this.lblmonthprompt.TabIndex = 5;
            this.lblmonthprompt.Text = "Enter the name of the month";
            // 
            // lbldayOfmonthprompt
            // 
            this.lbldayOfmonthprompt.AutoSize = true;
            this.lbldayOfmonthprompt.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbldayOfmonthprompt.Location = new System.Drawing.Point(12, 197);
            this.lbldayOfmonthprompt.Name = "lbldayOfmonthprompt";
            this.lbldayOfmonthprompt.Size = new System.Drawing.Size(440, 33);
            this.lbldayOfmonthprompt.TabIndex = 6;
            this.lbldayOfmonthprompt.Text = "Enter the numeric day of the month";
            this.lbldayOfmonthprompt.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblyearprompt
            // 
            this.lblyearprompt.AutoSize = true;
            this.lblyearprompt.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblyearprompt.Location = new System.Drawing.Point(251, 263);
            this.lblyearprompt.Name = "lblyearprompt";
            this.lblyearprompt.Size = new System.Drawing.Size(183, 33);
            this.lblyearprompt.TabIndex = 7;
            this.lblyearprompt.Text = "Enter the year";
            this.lblyearprompt.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbldateoutput
            // 
            this.lbldateoutput.BackColor = System.Drawing.SystemColors.Window;
            this.lbldateoutput.Location = new System.Drawing.Point(60, 362);
            this.lbldateoutput.Name = "lbldateoutput";
            this.lbldateoutput.Size = new System.Drawing.Size(765, 72);
            this.lbldateoutput.TabIndex = 8;
            // 
            // btnshowdate
            // 
            this.btnshowdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshowdate.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.Location = new System.Drawing.Point(80, 460);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(230, 63);
            this.btnshowdate.TabIndex = 9;
            this.btnshowdate.Text = "Show Date";
            this.btnshowdate.UseVisualStyleBackColor = false;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(400, 460);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(189, 63);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(636, 460);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(189, 63);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 544);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.lbldateoutput);
            this.Controls.Add(this.lblyearprompt);
            this.Controls.Add(this.lbldayOfmonthprompt);
            this.Controls.Add(this.lblmonthprompt);
            this.Controls.Add(this.lbldayOfweekprompt);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayOfmonth);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayOfweek);
            this.Name = "Form1";
            this.Text = "Birth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdayOfweek;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdayOfmonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lbldayOfweekprompt;
        private System.Windows.Forms.Label lblmonthprompt;
        private System.Windows.Forms.Label lbldayOfmonthprompt;
        private System.Windows.Forms.Label lblyearprompt;
        private System.Windows.Forms.Label lbldateoutput;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

