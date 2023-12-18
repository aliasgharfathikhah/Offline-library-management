namespace Library_management
{
    partial class BookUser
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(144, 197);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(484, 39);
            dateTimePicker1.TabIndex = 60;
            // 
            // add
            // 
            add.BackColor = Color.LimeGreen;
            add.Cursor = Cursors.Hand;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            add.ForeColor = Color.White;
            add.Location = new Point(232, 363);
            add.Name = "add";
            add.Size = new Size(316, 74);
            add.TabIndex = 59;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(471, 57);
            label2.Name = "label2";
            label2.Size = new Size(217, 32);
            label2.TabIndex = 58;
            label2.Text = "Book selection";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_book_50;
            pictureBox1.Location = new Point(412, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Gainsboro;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(471, 103);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(251, 40);
            comboBox2.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 57);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 55;
            label1.Text = "User selection";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.icons8_name_50;
            pictureBox11.Location = new Point(34, 94);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(50, 50);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 53;
            pictureBox11.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gainsboro;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 40);
            comboBox1.TabIndex = 54;
            // 
            // BookUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(add);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox11);
            Controls.Add(comboBox1);
            Name = "BookUser";
            Text = "BookUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
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
    }
}