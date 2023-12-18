namespace Library_management
{
    partial class Myprofile
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
            add = new Button();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem6 = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox11 = new PictureBox();
            comboBox1 = new ComboBox();
            panel10 = new Panel();
            trackBar1 = new TrackBar();
            pictureBox10 = new PictureBox();
            age = new TextBox();
            panel9 = new Panel();
            pictureBox9 = new PictureBox();
            address = new TextBox();
            panel8 = new Panel();
            pictureBox8 = new PictureBox();
            city = new TextBox();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            nationalid = new TextBox();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            email = new TextBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            password = new TextBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            username = new TextBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            phone = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lname = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            name = new TextBox();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            add.Location = new Point(876, 418);
            add.Name = "add";
            add.Size = new Size(324, 74);
            add.TabIndex = 37;
            add.Text = "Save";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Silver;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem6 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(128, 497);
            menuStrip2.TabIndex = 51;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Image = Properties.Resources.icons8_books_80_1_;
            toolStripMenuItem6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem6.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(143, 104);
            toolStripMenuItem6.Text = "Show books";
            toolStripMenuItem6.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(937, 285);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 50;
            label1.Text = "Gender :";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.icons8_customer_50;
            pictureBox11.Location = new Point(878, 316);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(50, 50);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 38;
            pictureBox11.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gainsboro;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(937, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 40);
            comboBox1.TabIndex = 49;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(trackBar1);
            panel10.Controls.Add(pictureBox10);
            panel10.Controls.Add(age);
            panel10.Location = new Point(523, 285);
            panel10.Name = "panel10";
            panel10.Size = new Size(322, 80);
            panel10.TabIndex = 48;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(76, 40);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(234, 56);
            trackBar1.TabIndex = 9;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.icons8_elderly_person_501;
            pictureBox10.Location = new Point(13, 13);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(50, 50);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            // 
            // age
            // 
            age.BorderStyle = BorderStyle.None;
            age.Cursor = Cursors.IBeam;
            age.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            age.Location = new Point(76, 3);
            age.Name = "age";
            age.PlaceholderText = "Age";
            age.Size = new Size(234, 32);
            age.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(pictureBox9);
            panel9.Controls.Add(address);
            panel9.Location = new Point(169, 285);
            panel9.Name = "panel9";
            panel9.Size = new Size(322, 80);
            panel9.TabIndex = 47;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.icons8_map_marker_50;
            pictureBox9.Location = new Point(13, 13);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(50, 50);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // address
            // 
            address.BorderStyle = BorderStyle.None;
            address.Cursor = Cursors.IBeam;
            address.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            address.Location = new Point(76, 24);
            address.Name = "address";
            address.PlaceholderText = "Address";
            address.Size = new Size(234, 32);
            address.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(pictureBox8);
            panel8.Controls.Add(city);
            panel8.Location = new Point(878, 166);
            panel8.Name = "panel8";
            panel8.Size = new Size(322, 80);
            panel8.TabIndex = 42;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.icons8_skyscrapers_50;
            pictureBox8.Location = new Point(13, 13);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(50, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 8;
            pictureBox8.TabStop = false;
            // 
            // city
            // 
            city.BorderStyle = BorderStyle.None;
            city.Cursor = Cursors.IBeam;
            city.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            city.Location = new Point(76, 24);
            city.Name = "city";
            city.PlaceholderText = "City";
            city.Size = new Size(234, 32);
            city.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(nationalid);
            panel7.Location = new Point(523, 166);
            panel7.Name = "panel7";
            panel7.Size = new Size(322, 80);
            panel7.TabIndex = 43;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_folk_music_50;
            pictureBox7.Location = new Point(13, 13);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // nationalid
            // 
            nationalid.BorderStyle = BorderStyle.None;
            nationalid.Cursor = Cursors.IBeam;
            nationalid.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nationalid.Location = new Point(76, 24);
            nationalid.Name = "nationalid";
            nationalid.PlaceholderText = "National id";
            nationalid.Size = new Size(234, 32);
            nationalid.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(email);
            panel6.Location = new Point(169, 166);
            panel6.Name = "panel6";
            panel6.Size = new Size(322, 80);
            panel6.TabIndex = 44;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_email_50;
            pictureBox6.Location = new Point(13, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.None;
            email.Cursor = Cursors.IBeam;
            email.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(76, 24);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(234, 32);
            email.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(password);
            panel5.Location = new Point(523, 409);
            panel5.Name = "panel5";
            panel5.Size = new Size(322, 80);
            panel5.TabIndex = 46;
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(username);
            panel4.Location = new Point(169, 409);
            panel4.Name = "panel4";
            panel4.Size = new Size(322, 80);
            panel4.TabIndex = 45;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_username_50;
            pictureBox4.Location = new Point(13, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(phone);
            panel3.Location = new Point(878, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 80);
            panel3.TabIndex = 41;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_phone_50;
            pictureBox3.Location = new Point(13, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // phone
            // 
            phone.BorderStyle = BorderStyle.None;
            phone.Cursor = Cursors.IBeam;
            phone.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(76, 24);
            phone.Name = "phone";
            phone.PlaceholderText = "Phone";
            phone.Size = new Size(234, 32);
            phone.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lname);
            panel2.Location = new Point(523, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 80);
            panel2.TabIndex = 40;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_name_50;
            pictureBox2.Location = new Point(13, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lname
            // 
            lname.BorderStyle = BorderStyle.None;
            lname.Cursor = Cursors.IBeam;
            lname.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lname.Location = new Point(76, 24);
            lname.Name = "lname";
            lname.PlaceholderText = "Last name";
            lname.Size = new Size(234, 32);
            lname.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(name);
            panel1.Location = new Point(169, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 80);
            panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_name_50;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // name
            // 
            name.BorderStyle = BorderStyle.None;
            name.Cursor = Cursors.IBeam;
            name.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(76, 24);
            name.Name = "name";
            name.PlaceholderText = "Name";
            name.Size = new Size(234, 32);
            name.TabIndex = 8;
            // 
            // Myprofile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 497);
            Controls.Add(add);
            Controls.Add(menuStrip2);
            Controls.Add(label1);
            Controls.Add(pictureBox11);
            Controls.Add(comboBox1);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Myprofile";
            Text = "Myprofile";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem6;
        private Label label1;
        private PictureBox pictureBox11;
        private ComboBox comboBox1;
        private Panel panel10;
        private TrackBar trackBar1;
        private PictureBox pictureBox10;
        private TextBox age;
        private Panel panel9;
        private PictureBox pictureBox9;
        private TextBox address;
        private Panel panel8;
        private PictureBox pictureBox8;
        private TextBox city;
        private Panel panel7;
        private PictureBox pictureBox7;
        private TextBox nationalid;
        private Panel panel6;
        private PictureBox pictureBox6;
        private TextBox email;
        private Panel panel5;
        private PictureBox pictureBox5;
        private TextBox password;
        private Panel panel4;
        private PictureBox pictureBox4;
        private TextBox username;
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox phone;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox lname;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox name;
    }
}