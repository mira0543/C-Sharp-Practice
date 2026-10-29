namespace Assignment_Files
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.listboxResult = new System.Windows.Forms.ListBox();
            this.btnCreatePath = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnReadToEnd = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReadAllLines = new System.Windows.Forms.Button();
            this.btnReadLine = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReadAllText = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(286, 114);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "1. Creating New File";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // listboxResult
            // 
            this.listboxResult.FormattingEnabled = true;
            this.listboxResult.ItemHeight = 20;
            this.listboxResult.Items.AddRange(new object[] {
            " "});
            this.listboxResult.Location = new System.Drawing.Point(658, 5);
            this.listboxResult.Name = "listboxResult";
            this.listboxResult.Size = new System.Drawing.Size(514, 704);
            this.listboxResult.TabIndex = 1;
            // 
            // btnCreatePath
            // 
            this.btnCreatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePath.Location = new System.Drawing.Point(304, 12);
            this.btnCreatePath.Name = "btnCreatePath";
            this.btnCreatePath.Size = new System.Drawing.Size(286, 114);
            this.btnCreatePath.TabIndex = 2;
            this.btnCreatePath.Text = "2. Creating New File Using Path";
            this.btnCreatePath.UseVisualStyleBackColor = true;
            this.btnCreatePath.Click += new System.EventHandler(this.btnCreatePath_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppend.Location = new System.Drawing.Point(12, 141);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(286, 114);
            this.btnAppend.TabIndex = 3;
            this.btnAppend.Text = "3. Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnOther
            // 
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(12, 514);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(286, 114);
            this.btnOther.TabIndex = 4;
            this.btnOther.Text = "9. Reading Other Function";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnReadToEnd
            // 
            this.btnReadToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadToEnd.Location = new System.Drawing.Point(304, 274);
            this.btnReadToEnd.Name = "btnReadToEnd";
            this.btnReadToEnd.Size = new System.Drawing.Size(286, 114);
            this.btnReadToEnd.TabIndex = 5;
            this.btnReadToEnd.Text = "6. Read the File Using ReadToEnd()";
            this.btnReadToEnd.UseVisualStyleBackColor = true;
            this.btnReadToEnd.Click += new System.EventHandler(this.btnReadToEnd_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(12, 274);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(286, 114);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "5. Read the File Using Read()";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnReadAllLines
            // 
            this.btnReadAllLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAllLines.Location = new System.Drawing.Point(12, 394);
            this.btnReadAllLines.Name = "btnReadAllLines";
            this.btnReadAllLines.Size = new System.Drawing.Size(286, 114);
            this.btnReadAllLines.TabIndex = 7;
            this.btnReadAllLines.Text = "7. Read the File Using ReadAllLines()";
            this.btnReadAllLines.UseVisualStyleBackColor = true;
            this.btnReadAllLines.Click += new System.EventHandler(this.btnReadAllLines_Click);
            // 
            // btnReadLine
            // 
            this.btnReadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadLine.Location = new System.Drawing.Point(304, 141);
            this.btnReadLine.Name = "btnReadLine";
            this.btnReadLine.Size = new System.Drawing.Size(286, 114);
            this.btnReadLine.TabIndex = 8;
            this.btnReadLine.Text = "4. Read the File Using ReadLine()";
            this.btnReadLine.UseVisualStyleBackColor = true;
            this.btnReadLine.Click += new System.EventHandler(this.btnReadLine_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(304, 514);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(286, 114);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "10. Delete the File";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReadAllText
            // 
            this.btnReadAllText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAllText.Location = new System.Drawing.Point(304, 394);
            this.btnReadAllText.Name = "btnReadAllText";
            this.btnReadAllText.Size = new System.Drawing.Size(286, 114);
            this.btnReadAllText.TabIndex = 10;
            this.btnReadAllText.Text = "8. Read the File Using ReadAllText()";
            this.btnReadAllText.UseVisualStyleBackColor = true;
            this.btnReadAllText.Click += new System.EventHandler(this.btnReadAllText_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(91, 634);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(438, 84);
            this.btnDeleteItem.TabIndex = 11;
            this.btnDeleteItem.Text = "11. Delete the Item File";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 721);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnReadAllText);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReadLine);
            this.Controls.Add(this.btnReadAllLines);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnReadToEnd);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnCreatePath);
            this.Controls.Add(this.listboxResult);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox listboxResult;
        private System.Windows.Forms.Button btnCreatePath;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnReadToEnd;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnReadAllLines;
        private System.Windows.Forms.Button btnReadLine;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReadAllText;
        private System.Windows.Forms.Button btnDeleteItem;
    }
}

