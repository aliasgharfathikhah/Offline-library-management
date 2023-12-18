namespace Library_management
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            textBox5 = new TextBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(textBox5);
            panel5.Location = new Point(268, 215);
            panel5.Name = "panel5";
            panel5.Size = new Size(322, 80);
            panel5.TabIndex = 12;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_password_50;
            pictureBox5.Location = new Point(13, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(76, 24);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.PlaceholderText = "Password";
            textBox5.Size = new Size(234, 32);
            textBox5.TabIndex = 8;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyDown += textBox5_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 51);
            label1.TabIndex = 13;
            label1.Text = "Welcome ";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(19, 457);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(791, 29);
            progressBar1.TabIndex = 14;
            progressBar1.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._22__14_;
            ClientSize = new Size(832, 498);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(panel5);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private PictureBox pictureBox5;
        private TextBox textBox5;
        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}