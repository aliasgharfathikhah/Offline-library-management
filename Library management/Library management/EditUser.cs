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
using System.Diagnostics.Metrics;

namespace Library_management
{
    public partial class EditUser : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "users_info.txt");
        FileWriterFromUsers fileWriterFromUsers = new FileWriterFromUsers();
        string id;
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
        public EditUser(string n, string ln, string p, string e, string nid, string c, string a, string ag, string g, string u, string pass, string idor)
        {
            InitializeComponent();
            ApplyRoundedCorners();
            name.Text = n;
            lname.Text = ln;
            phone.Text = p;
            email.Text = e;
            nationalid.Text = nid;
            city.Text = c;
            address.Text = a;
            age.Text = ag;
            trackBar1.Value = Convert.ToInt32(ag);
            if (g == "Male")
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
            username.Text = u;
            password.Text = pass;
            id = idor;
            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(add, 20);
            forgerdKardan.SetRoundedButton(button1, 20);
        }

        // edit user info
        private void add_Click_1(object sender, EventArgs e)
        {
            List<Users> users = fileWriterFromUsers.ReadUserInfoFromFile(filePath);

            DateTime dateTime = DateTime.Now;

            foreach (Users user in users)
            {
                if (user.id == id)
                {
                    user.Name = name.Text;
                    user.Lastname = lname.Text;
                    user.Phone = phone.Text;
                    user.Email = email.Text;
                    user.Nationalid = nationalid.Text;
                    user.City = city.Text;
                    user.Address = address.Text;
                    user.Age = age.Text;
                    user.Username = username.Text;
                    user.Password = password.Text;
                    user.Update = dateTime.ToString();
                    user.Gender = comboBox1.SelectedItem.ToString();
                }
            }

            fileWriterFromUsers.WriteUsersInfoToFile(users, filePath);
            MessageBox.Show("The information has been updated", "Warning", MessageBoxButtons.OK);
            Showusers showusers = new Showusers();
            showusers.Show();
            this.Hide();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this user?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                fileWriterFromUsers.DeleteUser(id, filePath);

                Showusers showusers = new Showusers();
                showusers.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}
