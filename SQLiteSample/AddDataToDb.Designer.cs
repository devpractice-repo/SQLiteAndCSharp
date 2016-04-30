namespace SQLiteSample
{
    partial class AddDataToDb
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbBook = new System.Windows.Forms.Label();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.btCancelbtCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBook);
            this.groupBox1.Controls.Add(this.tbBook);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.tbAuthor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // tbAuthor
            // 
            this.tbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAuthor.Location = new System.Drawing.Point(51, 23);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(211, 20);
            this.tbAuthor.TabIndex = 0;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(7, 26);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(41, 13);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "Author:";
            // 
            // lbBook
            // 
            this.lbBook.AutoSize = true;
            this.lbBook.Location = new System.Drawing.Point(7, 52);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(35, 13);
            this.lbBook.TabIndex = 3;
            this.lbBook.Text = "Book:";
            // 
            // tbBook
            // 
            this.tbBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBook.Location = new System.Drawing.Point(51, 49);
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(211, 20);
            this.tbBook.TabIndex = 2;
            // 
            // btCancelbtCancel
            // 
            this.btCancelbtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelbtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelbtCancel.Location = new System.Drawing.Point(205, 104);
            this.btCancelbtCancel.Name = "btCancelbtCancel";
            this.btCancelbtCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancelbtCancel.TabIndex = 1;
            this.btCancelbtCancel.Text = "Cancel";
            this.btCancelbtCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Location = new System.Drawing.Point(124, 104);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // AddDataToDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancelbtCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDataToDb";
            this.Text = "Add data to DB";
            this.Load += new System.EventHandler(this.AddDataToDb_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Button btCancelbtCancel;
        private System.Windows.Forms.Button btOK;
    }
}