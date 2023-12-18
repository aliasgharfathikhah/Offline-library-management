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
    public partial class ShowbookForUser : Form
    {
        FileWriterFromBooks fileWriterFromBooks = new FileWriterFromBooks();
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "books_info.txt");

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

        string name3;
        string id3;
        public ShowbookForUser(string username, string userid)
        {
            InitializeComponent();
            name3 = username;
            id3 = userid;
            List<Books> books = fileWriterFromBooks.ReadBooksInfoFromFile(filePath);

            int y = 220;
            foreach (Books book in books)
            {
                if (book.Status == true)
                {
                    Label label = new Label();
                    label.Text += $"Name: {book.Name}      Code: {book.Code}        Price: {book.Price}\n\nAuthor: {book.Author}        Publisher: {book.Publisher}      Book shelf: {book.Bookshelf}\n\nCreated at: {book.CreatedAt}\n\nUpdated at: {book.UpdatedAt}";
                    label.Font = new Font("Arial Rounded MT Bold", 15.2f);
                    label.AutoSize = true;
                    label.Location = new Point(13, 140);

                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Text = book.Id;
                    linkLabel.Font = new Font("Arial Rounded MT Bold", 16.2f);
                    linkLabel.AutoSize = true;
                    linkLabel.Location = new Point(170, 50);
                    linkLabel.LinkClicked += LinkLabel_LinkClicked;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(book.Picture);
                    pictureBox.Size = new Size(160, 140);
                    pictureBox.Location = new Point(13, 5);
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
                    Region region = new Region(path);
                    pictureBox.Region = region;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    Panel panel = new Panel();
                    panel.Location = new Point(117, y);
                    panel.Size = new Size(800, 360);
                    panel.BackColor = Color.Gainsboro;
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(label);
                    panel.Controls.Add(linkLabel);
                    this.Controls.Add(panel);
                    y += 400;
                }


            }
            ApplyRoundedCorners();
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            List<Books> books = fileWriterFromBooks.ReadBooksInfoFromFile(filePath);
            foreach (Books book in books)
            {
                if (linkLabel.Text == book.Id)
                {
                    BookUser bookUser = new BookUser(name3, id3, book.Name, book.Code);
                    bookUser.Show();
                    this.Close();
                    return;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Panel && c != panel1)
                    {
                        this.Controls.Remove(c);
                    }
                }

                List<Books> books = fileWriterFromBooks.ReadBooksInfoFromFile(filePath);
                int y = 220;
                foreach (Books book in books)
                {
                    if (book.Name == search.Text && book.Status == true)
                    {
                        Label label = new Label();
                        label.Text += $"Name: {book.Name}      Code: {book.Code}        Price: {book.Price}\n\nAuthor: {book.Author}        Publisher: {book.Publisher}      Book shelf: {book.Bookshelf}\n\nCreated at: {book.CreatedAt}\n\nUpdated at: {book.UpdatedAt}";
                        label.Font = new Font("Arial Rounded MT Bold", 15.2f);
                        label.AutoSize = true;
                        label.Location = new Point(13, 140);

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = book.Id;
                        linkLabel.Font = new Font("Arial Rounded MT Bold", 16.2f);
                        linkLabel.AutoSize = true;
                        linkLabel.Location = new Point(170, 50);
                        linkLabel.LinkClicked += LinkLabel_LinkClicked;

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromFile(book.Picture);
                        pictureBox.Size = new Size(160, 140);
                        pictureBox.Location = new Point(13, 5);
                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
                        Region region = new Region(path);
                        pictureBox.Region = region;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                        Panel panel = new Panel();
                        panel.Location = new Point(117, y);
                        panel.Size = new Size(800, 360);
                        panel.BackColor = Color.Gainsboro;
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(label);
                        panel.Controls.Add(linkLabel);
                        this.Controls.Add(panel);
                        y += 400;
                    }

                }
            }
        }

        private void re_Click(object sender, EventArgs e)
        {
            List<Books> books = fileWriterFromBooks.ReadBooksInfoFromFile(filePath);

            int y = 220;
            foreach (Books book in books)
            {
                if (book.Status == true)
                {
                    Label label = new Label();
                    label.Text += $"Name: {book.Name}      Code: {book.Code}        Price: {book.Price}\n\nAuthor: {book.Author}        Publisher: {book.Publisher}      Book shelf: {book.Bookshelf}\n\nCreated at: {book.CreatedAt}\n\nUpdated at: {book.UpdatedAt}";
                    label.Font = new Font("Arial Rounded MT Bold", 15.2f);
                    label.AutoSize = true;
                    label.Location = new Point(13, 140);

                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Text = book.Id;
                    linkLabel.Font = new Font("Arial Rounded MT Bold", 16.2f);
                    linkLabel.AutoSize = true;
                    linkLabel.Location = new Point(170, 50);
                    linkLabel.LinkClicked += LinkLabel_LinkClicked;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(book.Picture);
                    pictureBox.Size = new Size(160, 140);
                    pictureBox.Location = new Point(13, 5);
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
                    Region region = new Region(path);
                    pictureBox.Region = region;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    Panel panel = new Panel();
                    panel.Location = new Point(117, y);
                    panel.Size = new Size(800, 360);
                    panel.BackColor = Color.Gainsboro;
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(label);
                    panel.Controls.Add(linkLabel);
                    this.Controls.Add(panel);
                    y += 400;
                }


            }
        }
    }
}
