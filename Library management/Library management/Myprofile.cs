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
    public partial class Myprofile : Form
    {
        string id;
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "users_info.txt");

        string name3;
        string id3;
        public Myprofile(string n, string ln, string p, string e, string nid, string c, string a, string ag, string g, string u, string pass, string idor)
        {
            InitializeComponent();
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

            name3 = u;
            id3 = id;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ShowbookForUser showbookForUser = new ShowbookForUser(name3, id3);
            showbookForUser.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            FileWriterFromUsers fileWriterFromUsers = new FileWriterFromUsers();

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
            
        }
    }
}
