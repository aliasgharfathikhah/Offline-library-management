using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Library_management
{
    public partial class Editbook : Form
    {

        FileWriterFromBookShelf fileWriterFromBookShelf = new FileWriterFromBookShelf();
        FileWriterFromBooks fileWriterFromBooks = new FileWriterFromBooks();
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "book_shelf_info.txt");
        string filePathOr = Path.Combine(projectDirectory, "books_info.txt");

        int id;
        string picgh;
        public Editbook(string n, string c, string pic, string a, string pub, string pri, string bookshel, int id2)
        {

            id = id2;
            InitializeComponent();
            name.Text = n;
            code.Text = c;
            pictureBox3.Image = Image.FromFile(pic);
            author.Text = a;
            publisher.Text = pub;
            price.Text = pri;
            picgh = pic;
            List<BookShelf> bookShelves = fileWriterFromBookShelf.ReadBookShelfInfoFromFile(filePath);
            foreach (BookShelf bookShelf in bookShelves)
            {
                comboBox1.Items.Add(bookShelf.Name);
            }
            comboBox1.SelectedItem = bookshel;


            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(add, 20);
            forgerdKardan.SetRoundedButton(button1, 20);
            forgerdKardan.SetRoundedButton(button2, 20);
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
            Showbooks showbooks = new Showbooks();
            showbooks.Show();
            this.Hide();
        }

        // open show users form
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Showusers showusers = new Showusers();
            showusers.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            List<Books> books = fileWriterFromBooks.ReadBooksInfoFromFile(filePathOr);

            DateTime dateTime = DateTime.Now;

            foreach (Books book in books)
            {
                if (Convert.ToInt32(book.Id) == id)
                {
                    book.Name = name.Text;
                    book.Code = code.Text;
                    book.Author = author.Text;
                    book.Publisher = publisher.Text;
                    book.Price = price.Text;
                    book.Status = true;
                    book.Bookshelf = comboBox1.SelectedItem.ToString();
                    book.UpdatedAt = dateTime.ToString();
                }
            }

            fileWriterFromBooks.WriteBooksInfoToFile(books, filePathOr);
            MessageBox.Show("The information has been updated", "Warning", MessageBoxButtons.OK);
            Showbooks showbooks = new Showbooks();
            showbooks.Show();
            this.Hide();
        }

        public void CloseImage(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this book?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                CloseImage(pictureBox3);
                try
                {

                    fileWriterFromBooks.DeleteBook(id.ToString(), filePathOr);
                    pictureBox3.Image = null;
                    Showbooks showbooks = new Showbooks();
                    showbooks.Show();
                    this.Hide();
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

            }
        }
    }
}
