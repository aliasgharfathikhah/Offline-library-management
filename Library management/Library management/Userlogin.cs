using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class Userlogin : Form
    {

        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "users_info.txt");
        public Userlogin()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(add, 20);
        }

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
            FileWriterFromUsers fileWriterFromUsers = new FileWriterFromUsers();
            List<Users> users = fileWriterFromUsers.ReadUserInfoFromFile(filePath);
            string passwordMD5 = ConvertToMD5(password.Text);
            foreach (Users user in users)
            {
                if (username.Text == user.Username && passwordMD5 == user.Password)
                {
                    Myprofile myprofile = new Myprofile(user.Name, user.Lastname, user.Phone, user.Email, user.Nationalid, user.City, user.Address, user.Age, user.Gender, user.Username, user.Password, user.id);
                    myprofile.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("404 :)");
        }
    }
}
