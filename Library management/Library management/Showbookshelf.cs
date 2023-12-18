using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Showbookshelf : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "book_shelf_info.txt");
        FileWriterFromUsers FileWriterFromUsers = new FileWriterFromUsers();

        private void ApplyRoundedCorners()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 15, 15));
                    control.Padding = new Padding(10);
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        FileWriterFromBookShelf fileWriterFromBookShelf = new FileWriterFromBookShelf();
        public Showbookshelf()
        {

            InitializeComponent();
            

            List<BookShelf> bookShelves = fileWriterFromBookShelf.ReadBookShelfInfoFromFile(filePath);
            int y = 170;

            foreach (BookShelf bookShelf in bookShelves)
            {
                Label label = new Label();
                label.Text += $"Book shelves name: {bookShelf.Name} Order: {bookShelf.Order}";
                label.Font = new Font("Arial Rounded MT Bold", 15.2f);
                label.AutoSize = true;
                label.Location = new Point(13, 40);

                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Text = bookShelf.Id;
                linkLabel.Font = new Font("Arial Rounded MT Bold", 16.2f);
                linkLabel.AutoSize = true;
                linkLabel.Location = new Point(0, 0);
                linkLabel.LinkClicked += LinkLabel_LinkClicked;

                Panel panel = new Panel();
                panel.Location = new Point(117, y);
                panel.Size = new Size(700, 100);
                panel.BackColor = Color.Gainsboro;
                panel.Controls.Add(label);
                panel.Controls.Add(linkLabel);
                this.Controls.Add(panel);
                y += 100;

            }

            ApplyRoundedCorners();
        }


        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            List<BookShelf> bookShelves = fileWriterFromBookShelf.ReadBookShelfInfoFromFile(filePath);
            foreach (BookShelf bookShelf in bookShelves)
            {
                if (linkLabel.Text == bookShelf.Id)
                {
                    Editbookshelf editbookshelf = new Editbookshelf(bookShelf.Name, linkLabel.Text, bookShelf.Order);
                    editbookshelf.Show();
                    this.Hide();
                    return;
                }
            }
        }

        // open home form
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
