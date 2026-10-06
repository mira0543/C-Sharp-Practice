namespace Test_Score_Average
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
            this.groupboxtests = new System.Windows.Forms.Label();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupboxtests
            // 
            this.groupboxtests.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupboxtests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupboxtests.Location = new System.Drawing.Point(40, 36);
            this.groupboxtests.Name = "groupboxtests";
            this.groupboxtests.Size = new System.Drawing.Size(490, 284);
            this.groupboxtests.TabIndex = 0;
            this.groupboxtests.Text = "Enter Three Test Scores";
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblscore1.Location = new System.Drawing.Point(78, 85);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(163, 29);
            this.lblscore1.TabIndex = 1;
            this.lblscore1.Text = "Test Score #1";
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore2.Location = new System.Drawing.Point(78, 135);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(163, 29);
            this.lblscore2.TabIndex = 2;
            this.lblscore2.Text = "Test Score #2";
            // 
            // lblscore3
            // 
            this.lblscore3.AutoSize = true;
            this.lblscore3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblscore3.Location = new System.Drawing.Point(78, 188);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(163, 29);
            this.lblscore3.TabIndex = 3;
            this.lblscore3.Text = "Test Score #3";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblaverage.Location = new System.Drawing.Point(92, 258);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(108, 29);
            this.lblaverage.TabIndex = 4;
            this.lblaverage.Text = "Average:";
            // 
            // txtscore1
            // 
            this.txtscore1.Location = new System.Drawing.Point(294, 85);
            this.txtscore1.Multiline = true;
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(179, 39);
            this.txtscore1.TabIndex = 5;
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(294, 135);
            this.txtscore2.Multiline = true;
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(179, 39);
            this.txtscore2.TabIndex = 6;
            // 
            // txtscore3
            // 
            this.txtscore3.Location = new System.Drawing.Point(294, 188);
            this.txtscore3.Multiline = true;
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(179, 39);
            this.txtscore3.TabIndex = 7;
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbldisplay.Location = new System.Drawing.Point(251, 258);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(222, 42);
            this.lbldisplay.TabIndex = 8;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncalculate.Location = new System.Drawing.Point(97, 338);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(171, 79);
            this.btncalculate.TabIndex = 9;
            this.btncalculate.Text = "Calculate Average ";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnclear.Location = new System.Drawing.Point(294, 338);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(160, 31);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear ";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnexit.Location = new System.Drawing.Point(294, 386);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(160, 31);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.txtscore3);
            this.Controls.Add(this.txtscore2);
            this.Controls.Add(this.txtscore1);
            this.Controls.Add(this.lblaverage);
            this.Controls.Add(this.lblscore3);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.lblscore1);
            this.Controls.Add(this.groupboxtests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupboxtests;
        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

