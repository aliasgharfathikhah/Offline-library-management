using System.Security.Cryptography;
using System.Text;

namespace Library_management
{

    public partial class Form1 : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "manager_info.txt");
        void Check()
        {
            int count = 0;
            if (textBox1.Text.Length == 0)
            {
                count++;
            }
            if (textBox2.Text.Length == 0)
            {
                count++;
            }
            if (textBox3.Text.Length == 0)
            {
                count++;
            }
            if (textBox4.Text.Length == 0)
            {
                count++;
            }
            if (textBox5.Text.Length == 0)
            {
                count++;
            }

            if (count == 0)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("⚠Please fill in all fields⚠");
            }
        }
        public Form1()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager
            {
                Name = textBox1.Text,
                Lastname = textBox2.Text,
                Phone = textBox3.Text,
                Username = textBox4.Text,
                Password = ConvertToMD5(textBox5.Text),
            };

            FileWriter fileWriter = new FileWriter();
            fileWriter.WriteManagerToFile(manager, filePath);

            Check();
        }
    }
}