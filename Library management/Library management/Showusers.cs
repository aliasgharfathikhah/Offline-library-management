using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Library_management
{
    public partial class Showusers : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "users_info.txt");
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


        public Showusers()
        {
            InitializeComponent();
            List<Users> users = FileWriterFromUsers.ReadUserInfoFromFile(filePath);

            int y = 220;
            foreach (Users user in users)
            {
                Label label = new Label();
                label.Text += $"Name: {user.Name}       Last name: {user.Lastname}      Phone: {user.Phone}\n\nEmail: {user.Email}        National id: {user.Nationalid}      City: {user.City}\n\nAddress: {user.Address}        Age: {user.Age}       Gender: {user.Gender}\n\nUsername: {user.Username}       Password: {user.Password}\n\nDate of membership: {user.DateOfMembership}\n\nUpdate: {user.Update}";
                label.Font = new Font("Arial Rounded MT Bold", 15.2f);
                label.AutoSize = true;
                label.Location = new Point(13, 40);

                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Text = user.id;
                linkLabel.Font = new Font("Arial Rounded MT Bold", 16.2f);
                linkLabel.AutoSize = true;
                linkLabel.Location = new Point(0, 0);
                linkLabel.LinkClicked += LinkLabel_LinkClicked;

                Panel panel = new Panel();
                panel.Location = new Point(117, y);
                panel.Size = new Size(909, 390);
                panel.BackColor = Color.Gainsboro;
                panel.Controls.Add(label);
                panel.Controls.Add(linkLabel);
                this.Controls.Add(panel);
                y += 400;

            }
            ApplyRoundedCorners();
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            List<Users> users = FileWriterFromUsers.ReadUserInfoFromFile(filePath);
            foreach (Users user in users)
            {
                if (linkLabel.Text == user.id)
                {
                    EditUser editUser = new EditUser(user.Name, user.Lastname, user.Phone, user.Email, user.Nationalid, user.City, user.Address, user.Age, user.Gender, user.Username, user.Password, user.id);
                    editUser.Show();
                    this.Hide();
                    return;
                }
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Users> users = FileWriterFromUsers.ReadUserInfoFromFile(filePath);

                int y = 170;
                foreach (Users user in users)
                {
                    if (search.Text == user.Name)
                    {
                        MessageBox.Show($"Name: {user.Name}       Last name: {user.Lastname}      Phone: {user.Phone}\n\nEmail: {user.Email}        National id: {user.Nationalid}      City: {user.City}\n\nAddress: {user.Address}        Age: {user.Age}       Gender: {user.Gender}\n\nUsername: {user.Username}       Password: {user.Password}\n\nDate of membership: {user.DateOfMembership}\n\nUpdate: {user.Update}");
                    }
                    else
                    {
                        MessageBox.Show("Not found!");
                    }

                }
            }
        }
    }
}
