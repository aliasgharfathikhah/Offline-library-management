namespace Library_management
{
    partial class ShowbookForUser
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            search = new TextBox();
            re = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(search);
            panel1.Location = new Point(407, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 80);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_analyze_50;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // search
            // 
            search.BorderStyle = BorderStyle.None;
            search.Cursor = Cursors.IBeam;
            search.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            search.Location = new Point(76, 24);
            search.Name = "search";
            search.PlaceholderText = "Search";
            search.Size = new Size(234, 32);
            search.TabIndex = 8;
            search.KeyDown += search_KeyDown;
            // 
            // re
            // 
            re.BackColor = Color.LimeGreen;
            re.Cursor = Cursors.Hand;
            re.FlatStyle = FlatStyle.Flat;
            re.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            re.ForeColor = Color.White;
            re.Location = new Point(313, 135);
            re.Name = "re";
            re.Size = new Size(88, 74);
            re.TabIndex = 18;
            re.Text = "Re";
            re.UseVisualStyleBackColor = false;
            re.Click += re_Click;
            // 
            // ShowbookForUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1132, 554);
            Controls.Add(re);
            Controls.Add(panel1);
            Name = "ShowbookForUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowbookForUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox search;
        private Button re;
    }
}