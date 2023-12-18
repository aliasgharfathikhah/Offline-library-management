using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class Adduser : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "users_info.txt");
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
        public Adduser()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(add, 20);
        }

        public string ConvertToMD5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int id = random.Next(1000, 9999);
            DateTime dateTime = DateTime.Now;
            Users user = new Users
            {
                Name = name.Text,
                Lastname = lname.Text,
                Phone = phone.Text,
                Email = email.Text,
                Nationalid = nationalid.Text,
                City = city.Text,
                Address = address.Text,
                Age = age.Text,
                Username = username.Text,
                Password = ConvertToMD5(password.Text),
                id = id.ToString(),
                DateOfMembership = dateTime.ToString(),
                Update = dateTime.ToString(),
                Gender = comboBox1.SelectedItem.ToString(),
            };

            FileWriterFromUsers fileWriterFromUsers = new FileWriterFromUsers();
            fileWriterFromUsers.WriteUserInfoToFile(user, filePath);

            MessageBox.Show("User added successfully");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            age.Text = trackBar1.Value.ToString();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Showusers showusers = new Showusers();
            showusers.Show();
            this.Hide();
        }
    }
}
