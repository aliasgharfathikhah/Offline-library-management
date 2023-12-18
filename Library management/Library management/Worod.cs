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
    public partial class Worod : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "manager_info.txt");

        void OnShown()
        {

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(content))
                {
                    Login form2 = new Login();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
            else
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

        }
        public Worod()
        {
            InitializeComponent();
            ForgerdKardan forgerdKardan = new ForgerdKardan();
            forgerdKardan.SetRoundedButton(user, 20);
            forgerdKardan.SetRoundedButton(Admin, 20);
        }

        private void user_Click(object sender, EventArgs e)
        {
            Userlogin userlogin = new Userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            OnShown();
        }
    }
}
