namespace Akademine_Sistema
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            Grupes = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 74);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(21, 28);
            button1.Name = "button1";
            button1.Size = new Size(219, 62);
            button1.TabIndex = 0;
            button1.Text = "Grupės";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(21, 129);
            button2.Name = "button2";
            button2.Size = new Size(219, 62);
            button2.TabIndex = 1;
            button2.Text = "Dalykai";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button3.ForeColor = Color.Green;
            button3.Location = new Point(21, 335);
            button3.Name = "button3";
            button3.Size = new Size(219, 62);
            button3.TabIndex = 2;
            button3.Text = "Studentai";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button4.ForeColor = Color.Green;
            button4.Location = new Point(21, 233);
            button4.Name = "button4";
            button4.Size = new Size(219, 62);
            button4.TabIndex = 3;
            button4.Text = "Dėstytojai";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Maroon;
            button5.Location = new Point(21, 504);
            button5.Name = "button5";
            button5.Size = new Size(219, 62);
            button5.TabIndex = 4;
            button5.Text = "Atsijungti";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 601);
            panel1.TabIndex = 1;
            // 
            // Grupes
            // 
            Grupes.BackColor = SystemColors.AppWorkspace;
            Grupes.Location = new Point(259, 0);
            Grupes.Name = "Grupes";
            Grupes.Size = new Size(982, 672);
            Grupes.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 672);
            Controls.Add(Grupes);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Panel Grupes;
    }
}