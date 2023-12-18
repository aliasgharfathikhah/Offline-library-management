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
    public partial class Login : Form
    {
        Manager manager = new Manager();
        FileWriter fileWriter = new FileWriter();
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "manager_info.txt");
        public Login()
        {
            InitializeComponent();
            manager = fileWriter.ReadManagerFromFile(filePath);
            label1.Text += manager.Name;
            ApplyRoundedCorners();
            this.FormBorderStyle = FormBorderStyle.None;
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

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            string passwordMD5 = ConvertToMD5(textBox5.Text);
            if (e.KeyCode == Keys.Enter)
            {
                if (passwordMD5 == manager.Password)
                {
                    progressBar1.Visible = true;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("⚠Password is wrong⚠");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value + 25 <= 100)
            {
                progressBar1.Value += 25;
            }
            else
            {
                timer1.Stop();
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
