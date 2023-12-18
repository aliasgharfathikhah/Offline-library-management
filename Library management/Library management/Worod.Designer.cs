namespace Library_management
{
    partial class Worod
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
            user = new Button();
            Admin = new Button();
            SuspendLayout();
            // 
            // user
            // 
            user.BackColor = Color.DarkTurquoise;
            user.Cursor = Cursors.Hand;
            user.FlatStyle = FlatStyle.Flat;
            user.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            user.ForeColor = Color.White;
            user.Location = new Point(246, 76);
            user.Name = "user";
            user.Size = new Size(245, 64);
            user.TabIndex = 40;
            user.Text = "User";
            user.UseVisualStyleBackColor = false;
            user.Click += user_Click;
            // 
            // Admin
            // 
            Admin.BackColor = Color.RoyalBlue;
            Admin.Cursor = Cursors.Hand;
            Admin.FlatStyle = FlatStyle.Flat;
            Admin.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Admin.ForeColor = Color.White;
            Admin.Location = new Point(246, 168);
            Admin.Name = "Admin";
            Admin.Size = new Size(245, 64);
            Admin.TabIndex = 41;
            Admin.Text = "Admin";
            Admin.UseVisualStyleBackColor = false;
            Admin.Click += Admin_Click;
            // 
            // Worod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_blog_image;
            ClientSize = new Size(719, 363);
            ControlBox = false;
            Controls.Add(Admin);
            Controls.Add(user);
            Name = "Worod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Worod";
            ResumeLayout(false);
        }

        #endregion

        private Button user;
        private Button Admin;
    }
}