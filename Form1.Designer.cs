namespace Akademine_Sistema
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NoodleImg = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            checkBoxStudent = new CheckBox();
            checkBoxProfessor = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)NoodleImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // NoodleImg
            // 
            NoodleImg.BackColor = Color.Black;
            NoodleImg.Image = (Image)resources.GetObject("NoodleImg.Image");
            NoodleImg.Location = new Point(80, 12);
            NoodleImg.Name = "NoodleImg";
            NoodleImg.Size = new Size(260, 76);
            NoodleImg.TabIndex = 0;
            NoodleImg.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 293);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Geometr415 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 122);
            label1.Name = "label1";
            label1.Size = new Size(152, 29);
            label1.TabIndex = 3;
            label1.Text = "Prisijungimas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 101);
            panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(110, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(110, 304);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 29);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 184);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 7;
            label2.Text = "Vartotojo kodas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 275);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 8;
            label3.Text = "Slaptažodis";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Geometr415 Blk BT", 18F);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(124, 407);
            button1.Name = "button1";
            button1.Size = new Size(182, 52);
            button1.TabIndex = 9;
            button1.Text = "Prisijungti";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBoxStudent
            // 
            checkBoxStudent.AutoSize = true;
            checkBoxStudent.Location = new Point(124, 367);
            checkBoxStudent.Name = "checkBoxStudent";
            checkBoxStudent.Size = new Size(78, 19);
            checkBoxStudent.TabIndex = 10;
            checkBoxStudent.Text = "Studentas";
            checkBoxStudent.UseVisualStyleBackColor = true;
            // 
            // checkBoxProfessor
            // 
            checkBoxProfessor.AutoSize = true;
            checkBoxProfessor.Location = new Point(228, 367);
            checkBoxProfessor.Name = "checkBoxProfessor";
            checkBoxProfessor.Size = new Size(80, 19);
            checkBoxProfessor.TabIndex = 11;
            checkBoxProfessor.Text = "Dėstytojas";
            checkBoxProfessor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 501);
            Controls.Add(checkBoxProfessor);
            Controls.Add(checkBoxStudent);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(NoodleImg);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NoodleImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox NoodleImg;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private CheckBox checkBoxStudent;
        private CheckBox checkBoxProfessor;
    }
}
