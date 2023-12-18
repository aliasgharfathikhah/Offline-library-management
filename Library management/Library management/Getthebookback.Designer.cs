namespace Library_management
{
    partial class Getthebookback
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
            dateTimePicker1 = new DateTimePicker();
            add = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            pictureBox11 = new PictureBox();
            comboBox1 = new ComboBox();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(325, 213);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(484, 39);
            dateTimePicker1.TabIndex = 61;
            // 
            // add
            // 
            add.BackColor = Color.LimeGreen;
            add.Cursor = Cursors.Hand;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            add.ForeColor = Color.White;
            add.Location = new Point(413, 379);
            add.Name = "add";
            add.Size = new Size(316, 74);
            add.TabIndex = 60;
            add.Text = "Get Back";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(652, 73);
            label2.Name = "label2";
            label2.Size = new Size(217, 32);
            label2.TabIndex = 59;
            label2.Text = "Book selection";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_book_50;
            pictureBox1.Location = new Point(593, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Gainsboro;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(652, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(251, 40);
            comboBox2.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(274, 73);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 56;
            label1.Text = "User selection";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.icons8_name_50;
            pictureBox11.Location = new Point(215, 110);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(50, 50);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 54;
            pictureBox11.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gainsboro;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(274, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 40);
            comboBox1.TabIndex = 55;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Silver;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem2, toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(185, 531);
            menuStrip2.TabIndex = 53;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Image = Properties.Resources.icons8_home_80;
            toolStripMenuItem5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(172, 104);
            toolStripMenuItem5.Text = "Home";
            toolStripMenuItem5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Image = Properties.Resources.icons8_books_80_1_;
            toolStripMenuItem6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem6.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(172, 104);
            toolStripMenuItem6.Text = "Show books";
            toolStripMenuItem6.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.icons8_user_account_80;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(172, 104);
            toolStripMenuItem2.Text = "Show users";
            toolStripMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.icons8_book_shelf_80;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(172, 104);
            toolStripMenuItem1.Text = "Show book shelves";
            toolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Getthebookback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 531);
            Controls.Add(dateTimePicker1);
            Controls.Add(add);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox11);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip2);
            Name = "Getthebookback";
            Text = "Getthebookback";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button add;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox comboBox2;
        private Label label1;
        private PictureBox pictureBox11;
        private ComboBox comboBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}