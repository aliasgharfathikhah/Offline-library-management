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
    public partial class Editbookshelf : Form
    {
        string id;
        string orderor;
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "book_shelf_info.txt");
        FileWriterFromBookShelf fileWriterFromBookShelf = new FileWriterFromBookShelf();
        public Editbookshelf(string n, string idor, string order)
        {
            InitializeComponent();
            name.Text = n;
            id = idor;
            orderor = order;
            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(add, 20);
            forgerdKardan.SetRoundedButton(button1, 20);
        }

        // save book shelf info
        private void add_Click(object sender, EventArgs e)
        {
            List<BookShelf> list = fileWriterFromBookShelf.ReadBookShelfInfoFromFile(filePath);
            foreach (BookShelf bookShelf in list)
            {
                if (bookShelf.Id == id)
                {
                    bookShelf.Name = name.Text;
                    bookShelf.Id = id;
                    bookShelf.Order = orderor;
                }
            }
            fileWriterFromBookShelf.WriteBookShelfsInfoToFile(list, filePath);
            MessageBox.Show("The information has been updated", "Warning", MessageBoxButtons.OK);

            Showbookshelf showbookshelf = new Showbookshelf();
            showbookshelf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this book shelf?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                fileWriterFromBookShelf.DeleteBookShelf(id, filePath);
                MessageBox.Show("The information has been updated", "Warning", MessageBoxButtons.OK);

                Showbookshelf showbookshelf = new Showbookshelf();
                showbookshelf.Show();
                this.Hide();
            }
            else
            {

            }
        }

        // open home form
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        // open show books form
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        // open show users form
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Showusers showusers = new Showusers();
            showusers.Show();
            this.Hide();
        }

        // open show book sehlves form
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Showbookshelf showbookshelf = new Showbookshelf();
            showbookshelf.Show();
            this.Hide();
        }
    }
}
