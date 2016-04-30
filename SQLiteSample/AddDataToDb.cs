using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLiteSample
{
    public partial class AddDataToDb : Form
    {
        public String Author { get; set; }
        public String Book { get; set; }

        public AddDataToDb()
        {
            InitializeComponent();            
        }

        private void AddDataToDb_Load(object sender, EventArgs e)
        {
            Author = "Author";
            Book = "Book";

            tbAuthor.Text = Author;
            tbBook.Text = Book;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Author = tbAuthor.Text;
            Book = tbBook.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
