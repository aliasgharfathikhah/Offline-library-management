using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class AddBook : Form
    {
        FileWriterFromBookShelf fileWriterFromBookShelf = new FileWriterFromBookShelf();
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "book_shelf_info.txt");
        string filePathOr = Path.Combine(projectDirectory, "books_info.txt");
        FileWriterFromBooks fileWriterFromBooks = new FileWriterFromBooks();

        Books books = new Books();

        public AddBook()
        {
            InitializeComponent();
            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(add, 20);
            forgerdKardan.SetRoundedButton(button1, 20);
            List<BookShelf> bookShelves = fileWriterFromBookShelf.ReadBookShelfInfoFromFile(filePath);

            foreach (BookShelf bookShelf in bookShelves)
            {
                comboBox1.Items.Add(bookShelf.Name);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        // open form home
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        // open form show users
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Showusers showusers = new Showusers();
            showusers.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Browse image for Book";
            OpenFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG";
            OpenFileDialog.InitialDirectory = @"C:\";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = System.Drawing.Image.FromFile(OpenFileDialog.FileName);
                string imagesFolder = Path.Combine(Application.StartupPath, "Photo_of_the_book");
                Directory.CreateDirectory(imagesFolder);

                string destinationPath = Path.Combine(imagesFolder, Path.GetFileName(OpenFileDialog.FileName));

                File.Copy(OpenFileDialog.FileName, destinationPath, true);

                books.Picture = destinationPath;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            books.Name = name.Text;
            books.Code = code.Text;
            books.Author = author.Text;
            books.Publisher = publisher.Text;
            books.Price = price.Text;
            books.Status = true;
            books.Bookshelf = comboBox1.SelectedItem.ToString();

            DateTime dateTime = DateTime.Now;
            books.CreatedAt = dateTime.ToString();
            books.UpdatedAt = dateTime.ToString();

            Random random = new Random();
            int id = random.Next(1000, 9999);
            books.Id = id.ToString();

            fileWriterFromBooks.WriteBookInfoToFile(books, filePathOr);

            MessageBox.Show("Book information has been saved successfully!", "Warning", MessageBoxButtons.OK);


        }

        // open form show books
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Showbooks showbooks = new Showbooks();
            showbooks.Show();
            this.Hide();
        }
    }
}
