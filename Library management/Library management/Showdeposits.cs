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
    public partial class Showdeposits : Form
    {

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

        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        string filePath = Path.Combine(projectDirectory, "deposits_info.txt");
        FileWriterFromDeposits fileWriterFromDeposits = new FileWriterFromDeposits();
        public Showdeposits()
        {
            InitializeComponent();
            List<Deposits> deposits = fileWriterFromDeposits.ReadDepositsInfoFromFile(filePath);

            int y = 220;
            foreach (Deposits deposit in deposits)
            {
                Label label = new Label();
                label.Text += $"User: {deposit.UsernameAndUserId}   Book{deposit.BookNameAndBookCode}\n\nBorrow date: {deposit.BorrowDate}\n\nReturn date: {deposit.ReturnDate}";
                label.Font = new Font("Arial Rounded MT Bold", 15.2f);
                label.AutoSize = true;
                label.Location = new Point(13, 40);

                Panel panel = new Panel();
                panel.Location = new Point(117, y);
                panel.Size = new Size(909, 240);
                panel.BackColor = Color.Gainsboro;
                panel.Controls.Add(label);
                this.Controls.Add(panel);
                y += 250;

            }
            ApplyRoundedCorners();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
