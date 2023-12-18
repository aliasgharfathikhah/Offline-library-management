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
    public partial class lod : Form
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "manager_info.txt");
        
        public lod()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
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
                Worod worod = new Worod();
                worod.Show();
                this.Hide();
            }
        }
    }
}
