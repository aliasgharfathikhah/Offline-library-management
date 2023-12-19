namespace Library_management
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            menuStrip2 = new MenuStrip();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            price = new TextBox();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            author = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            code = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            name = new TextBox();
            add = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            publisher = new TextBox();
            menuStrip2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Silver;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem2, toolStripMenuItem6, toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(128, 544);
            menuStrip2.TabIndex = 34;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Image = Properties.Resources.icons8_home_80;
            toolStripMenuItem5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(115, 104);
            toolStripMenuItem5.Text = "Home";
            toolStripMenuItem5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.icons8_add_80;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(115, 104);
            toolStripMenuItem2.Text = "Add";
            toolStripMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Image = Properties.Resources.icons8_books_80_1_;
            toolStripMenuItem6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem6.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(115, 104);
            toolStripMenuItem6.Text = "Show books";
            toolStripMenuItem6.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.icons8_user_account_80;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(115, 104);
            toolStripMenuItem1.Text = "Show users";
            toolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(price);
            panel7.Location = new Point(855, 154);
            panel7.Name = "panel7";
            panel7.Size = new Size(322, 80);
            panel7.TabIndex = 28;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_price_tag_usd_50;
            pictureBox7.Location = new Point(13, 13);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // price
            // 
            price.BorderStyle = BorderStyle.None;
            price.Cursor = Cursors.IBeam;
            price.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(76, 24);
            price.Name = "price";
            price.PlaceholderText = "Price";
            price.Size = new Size(234, 32);
            price.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(author);
            panel6.Location = new Point(146, 154);
            panel6.Name = "panel6";
            panel6.Size = new Size(322, 80);
            panel6.TabIndex = 29;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_login_as_user_50;
            pictureBox6.Location = new Point(13, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // author
            // 
            author.BorderStyle = BorderStyle.None;
            author.Cursor = Cursors.IBeam;
            author.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            author.Location = new Point(76, 24);
            author.Name = "author";
            author.PlaceholderText = "Author";
            author.Size = new Size(234, 32);
            author.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(855, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 80);
            panel3.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(132, 11);
            button1.Name = "button1";
            button1.Size = new Size(177, 60);
            button1.TabIndex = 38;
            button1.Text = "Selection";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_picture_50;
            pictureBox3.Location = new Point(13, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(code);
            panel2.Location = new Point(500, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 80);
            panel2.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_informatics_50;
            pictureBox2.Location = new Point(13, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // code
            // 
            code.BorderStyle = BorderStyle.None;
            code.Cursor = Cursors.IBeam;
            code.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            code.Location = new Point(76, 24);
            code.Name = "code";
            code.PlaceholderText = "Code";
            code.Size = new Size(234, 32);
            code.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(name);
            panel1.Location = new Point(146, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 80);
            panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_book_50;
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
            // add
            // 
            add.BackColor = Color.LimeGreen;
            add.Cursor = Cursors.Hand;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            add.ForeColor = Color.White;
            add.Location = new Point(500, 397);
            add.Name = "add";
            add.Size = new Size(316, 74);
            add.TabIndex = 7;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(528, 269);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 37;
            label1.Text = "Shelvs :";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gainsboro;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(528, 309);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 40);
            comboBox1.TabIndex = 36;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(publisher);
            panel4.Location = new Point(500, 154);
            panel4.Name = "panel4";
            panel4.Size = new Size(322, 80);
            panel4.TabIndex = 38;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_microsoft_publisher_2019_48;
            pictureBox4.Location = new Point(13, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // publisher
            // 
            publisher.BorderStyle = BorderStyle.None;
            publisher.Cursor = Cursors.IBeam;
            publisher.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            publisher.Location = new Point(76, 24);
            publisher.Name = "publisher";
            publisher.PlaceholderText = "Publisher";
            publisher.Size = new Size(234, 32);
            publisher.TabIndex = 8;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 544);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(add);
            Controls.Add(menuStrip2);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBook";
            Text = "AddBook";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel7;
        private PictureBox pictureBox7;
        private TextBox price;
        private Panel panel6;
        private PictureBox pictureBox6;
        private TextBox author;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox code;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox name;
        private Button add;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Panel panel4;
        private PictureBox pictureBox4;
        private TextBox publisher;
    }
}