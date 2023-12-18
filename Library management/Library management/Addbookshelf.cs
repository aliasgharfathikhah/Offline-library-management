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
    public partial class Addbookshelf : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "book_shelf_info.txt");
        FileWriterFromUsers FileWriterFromUsers = new FileWriterFromUsers();

        public Addbookshelf()
        {
            InitializeComponent();
            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(add, 20);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            // find count in line
            int count = File.ReadLines(filePath).Count();

            BookShelf bookShelf = new BookShelf
            {
                Name = name.Text,
                Id = random.Next(1000, 9999).ToString(),
                Order = (count + 1).ToString(),

            };

            FileWriterFromBookShelf fileWriterFromBookShelf = new FileWriterFromBookShelf();
            fileWriterFromBookShelf.WriteBookShelfInfoToFile(bookShelf, filePath);
        }

        // open home form
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        // open show book shelves form
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Showbookshelf showbookshelf = new Showbookshelf();
            showbookshelf.Show();
            this.Hide();
        }

        // open show users form
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Showusers showusers = new Showusers();
            showusers.Show();
            this.Hide();
        }
    }
}
