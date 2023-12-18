namespace Library_management
{
    partial class Addbookshelf
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
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            name = new TextBox();
            menuStrip2.SuspendLayout();
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
            add.Location = new Point(378, 350);
            add.Name = "add";
            add.Size = new Size(316, 74);
            add.TabIndex = 35;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
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
            menuStrip2.Size = new Size(185, 555);
            menuStrip2.TabIndex = 40;
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
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
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
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(name);
            panel1.Location = new Point(372, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 80);
            panel1.TabIndex = 36;
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
            // Addbookshelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 555);
            Controls.Add(add);
            Controls.Add(menuStrip2);
            Controls.Add(panel1);
            Name = "Addbookshelf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addbookshelf";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox name;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}