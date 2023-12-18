namespace Library_management
{
    partial class Showbookshelf
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
            menuStrip2 = new MenuStrip();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Silver;
            menuStrip2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem2, toolStripMenuItem6 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1042, 108);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Image = Properties.Resources.icons8_home_80;
            toolStripMenuItem5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(94, 104);
            toolStripMenuItem5.Text = "Home";
            toolStripMenuItem5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4 });
            toolStripMenuItem2.Image = Properties.Resources.icons8_add_80;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Margin = new Padding(20, 0, 0, 0);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(94, 104);
            toolStripMenuItem2.Text = "Add";
            toolStripMenuItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = Color.Aqua;
            toolStripMenuItem3.Image = Properties.Resources.icons8_add_user_80;
            toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(231, 86);
            toolStripMenuItem3.Text = "Add user";
            toolStripMenuItem3.TextAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = Color.Aqua;
            toolStripMenuItem4.Image = Properties.Resources.icons8_book_80;
            toolStripMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(231, 86);
            toolStripMenuItem4.Text = "Add book";
            toolStripMenuItem4.TextAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Image = Properties.Resources.icons8_books_80_1_;
            toolStripMenuItem6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem6.Margin = new Padding(20, 0, 0, 0);
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(122, 104);
            toolStripMenuItem6.Text = "Show books";
            toolStripMenuItem6.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Showbookshelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1042, 484);
            Controls.Add(menuStrip2);
            Name = "Showbookshelf";
            Text = "Showbookshelf";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem6;
    }
}