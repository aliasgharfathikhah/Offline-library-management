namespace Library_management
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem1, toolStripMenuItem6, addUserToolStripMenuItem, toolStripMenuItem9, toolStripMenuItem8 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(172, 719);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.WhiteSmoke;
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem5, toolStripMenuItem4, toolStripMenuItem7 });
            toolStripMenuItem2.Image = Properties.Resources.icons8_add_80;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(159, 104);
            toolStripMenuItem2.Text = "Add";
            toolStripMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = Color.Gainsboro;
            toolStripMenuItem3.Image = Properties.Resources.icons8_add_user_80;
            toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(284, 86);
            toolStripMenuItem3.Text = "Add user";
            toolStripMenuItem3.TextAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.BackColor = Color.Gainsboro;
            toolStripMenuItem5.Image = Properties.Resources.icons8_book_80;
            toolStripMenuItem5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(284, 86);
            toolStripMenuItem5.Text = "Add book";
            toolStripMenuItem5.TextAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = Color.Gainsboro;
            toolStripMenuItem4.Image = Properties.Resources.icons8_book_shelf_80;
            toolStripMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(284, 86);
            toolStripMenuItem4.Text = "Add book shelf";
            toolStripMenuItem4.TextAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem4.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.BackColor = Color.Gainsboro;
            toolStripMenuItem7.Image = Properties.Resources.icons8_trust_64;
            toolStripMenuItem7.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(284, 86);
            toolStripMenuItem7.Text = "Lending book";
            toolStripMenuItem7.TextAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem7.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.icons8_user_account_80;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 104);
            toolStripMenuItem1.Text = "Show users";
            toolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Image = Properties.Resources.icons8_books_80_1_;
            toolStripMenuItem6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem6.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(159, 104);
            toolStripMenuItem6.Text = "Show books";
            toolStripMenuItem6.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Image = Properties.Resources.icons8_book_shelf_80;
            addUserToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addUserToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(159, 104);
            addUserToolStripMenuItem.Text = "Show book shelfs";
            addUserToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Image = (Image)resources.GetObject("toolStripMenuItem9.Image");
            toolStripMenuItem9.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem9.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(159, 88);
            toolStripMenuItem9.Text = "Get book back";
            toolStripMenuItem9.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem9.Click += toolStripMenuItem9_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Image = (Image)resources.GetObject("toolStripMenuItem8.Image");
            toolStripMenuItem8.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem8.Margin = new Padding(0, 20, 0, 0);
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(159, 88);
            toolStripMenuItem8.Text = "Show deposits";
            toolStripMenuItem8.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1414, 719);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
    }
}