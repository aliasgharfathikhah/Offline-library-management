using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        // open form show book shelves
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showbookshelf showbookshelf = new Showbookshelf();
            showbookshelf.Show(this);
            this.Hide();
        }

        // open form show users
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Showusers showusers = new Showusers();
            showusers.Show();
            this.Hide();
        }

        // open form add user
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Adduser adduser = new Adduser();
            adduser.Show();
            this.Hide();
        }

        // open form add book shelf
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Addbookshelf addbookshelf = new Addbookshelf();
            addbookshelf.Show();
            this.Hide();
        }

        // open form add book
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Hide();
        }

        // open form show books
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Showbooks showbooks = new Showbooks();
            showbooks.Show();
            this.Hide();
        }

        // 
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            RegistrationOfBookLoan registrationOfBookLoan = new RegistrationOfBookLoan();
            registrationOfBookLoan.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Showdeposits showdeposits = new Showdeposits();
            showdeposits.Show();
            this.Hide();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Getthebookback getthebookback = new Getthebookback();
            getthebookback.Show();
            this.Hide();
        }
    }
}
