namespace SQLiteSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btCreate = new System.Windows.Forms.ToolStripButton();
            this.btConnect = new System.Windows.Forms.ToolStripButton();
            this.btReadAll = new System.Windows.Forms.ToolStripButton();
            this.btClearTable = new System.Windows.Forms.ToolStripButton();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCreate,
            this.btConnect,
            this.btReadAll,
            this.btAdd,
            this.btClearTable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btCreate
            // 
            this.btCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btCreate.Image = ((System.Drawing.Image)(resources.GetObject("btCreate.Image")));
            this.btCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(44, 22);
            this.btCreate.Text = "Create";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btConnect
            // 
            this.btConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btConnect.Image = ((System.Drawing.Image)(resources.GetObject("btConnect.Image")));
            this.btConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(51, 22);
            this.btConnect.Text = "Connect";
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btReadAll
            // 
            this.btReadAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btReadAll.Image = ((System.Drawing.Image)(resources.GetObject("btReadAll.Image")));
            this.btReadAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btReadAll.Name = "btReadAll";
            this.btReadAll.Size = new System.Drawing.Size(49, 22);
            this.btReadAll.Text = "Read all";
            this.btReadAll.Click += new System.EventHandler(this.btReadAll_Click);
            // 
            // btClearTable
            // 
            this.btClearTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btClearTable.Image = ((System.Drawing.Image)(resources.GetObject("btClearTable.Image")));
            this.btClearTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClearTable.Name = "btClearTable";
            this.btClearTable.Size = new System.Drawing.Size(63, 22);
            this.btClearTable.Text = "Clear table";
            this.btClearTable.Click += new System.EventHandler(this.btClearTable_Click);
            // 
            // btAdd
            // 
            this.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(30, 22);
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.lbStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(42, 17);
            this.lbStatus.Text = "Status:";
            // 
            // lbStatusText
            // 
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(23, 17);
            this.lbStatusText.Text = "----";
            // 
            // dgvViewer
            // 
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Author,
            this.Book});
            this.dgvViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewer.Location = new System.Drawing.Point(0, 25);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.Size = new System.Drawing.Size(547, 237);
            this.dgvViewer.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.Width = 200;
            // 
            // Book
            // 
            this.Book.HeaderText = "Book";
            this.Book.Name = "Book";
            this.Book.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 284);
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "SQLite Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btCreate;
        private System.Windows.Forms.ToolStripButton btConnect;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusText;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.ToolStripButton btReadAll;
        private System.Windows.Forms.ToolStripButton btClearTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
    }
}

