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
    public partial class Getthebookback : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePathbook = Path.Combine(projectDirectory, "books_info.txt");
        string filePathuser = Path.Combine(projectDirectory, "users_info.txt");
        string filePathdeposits = Path.Combine(projectDirectory, "deposits_info.txt");
        FileWriterFromBooks fileWriterFromBooks = new FileWriterFromBooks();
        FileWriterFromUsers fileWriterFromUsers = new FileWriterFromUsers();
        FileWriterFromDeposits fileWriterFromDeposits = new FileWriterFromDeposits();

        public Getthebookback()
        {
            InitializeComponent();
            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(add, 20);
            List<Users> users = fileWriterFromUsers.ReadUserInfoFromFile(filePathuser);
            foreach (Users user in users)
            {
                comboBox1.Items.Add($"{user.Name} {user.id}");
            }

            List<Books> books = fileWriterFromBooks.ReadBooksInfoFromFile(filePathbook);
            foreach (Books book in books)
            {
                if (book.Status == false)
                {
                    comboBox2.Items.Add($"{book.Name} {book.Code}");
                }

            }
            DateTime dateTime = DateTime.Now;
            dateTimePicker1.Value = dateTime;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Deposits deposits = new Deposits
            {
                UsernameAndUserId = comboBox1.SelectedItem.ToString() + " |Back| ",
                BookNameAndBookCode = comboBox2.SelectedItem.ToString(),
                ReturnDate = dateTimePicker1.Value.ToString(),

            };

            fileWriterFromDeposits.WriteDepositsInfoToFile(deposits, filePathdeposits);

            string selectedBookCode = comboBox2.SelectedItem.ToString().Split(' ')[2];
            List<Books> books = fileWriterFromBooks.ReadBooksInfoFromFile(filePathbook);
            foreach (Books book in books)
            {
                if (book.Code == selectedBookCode)
                {
                    book.Status = true;
                    break;
                }
            }
            fileWriterFromBooks.WriteBooksInfoToFile(books, filePathbook);

            MessageBox.Show("It was successful");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
