namespace Library_management
{
    partial class Userlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userlogin));
            add = new Button();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            password = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            username = new TextBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // add
            // 
            add.BackColor = Color.LimeGreen;
            add.Cursor = Cursors.Hand;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            add.ForeColor = Color.White;
            add.Location = new Point(239, 344);
            add.Name = "add";
            add.Size = new Size(316, 74);
            add.TabIndex = 17;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(password);
            panel5.Location = new Point(236, 209);
            panel5.Name = "panel5";
            panel5.Size = new Size(322, 80);
            panel5.TabIndex = 19;
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
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Cursor = Cursors.IBeam;
            password.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(76, 24);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(234, 32);
            password.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(username);
            panel1.Location = new Point(239, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 80);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.None;
            username.Cursor = Cursors.IBeam;
            username.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(76, 24);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(234, 32);
            username.TabIndex = 8;
            // 
            // Userlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._22__25_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(788, 489);
            Controls.Add(panel1);
            Controls.Add(add);
            Controls.Add(panel5);
            Name = "Userlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Userlogin";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button add;
        private Panel panel5;
        private PictureBox pictureBox5;
        private TextBox password;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox username;
    }
}