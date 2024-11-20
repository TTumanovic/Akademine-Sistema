namespace Akademine_Sistema
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            cmbGroups = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 47);
            label1.TabIndex = 2;
            label1.Text = "Studentai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 3;
            label2.Text = "Vardas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 4;
            label3.Text = "Pavardė";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(318, 157);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(318, 109);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 6;
            label5.Text = "Username";
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 23);
            txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(107, 162);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(186, 23);
            txtSurname.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(425, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(186, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(425, 109);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(186, 23);
            txtUsername.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(862, 269);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.PaleGreen;
            button1.Location = new Point(12, 239);
            button1.Name = "button1";
            button1.Size = new Size(132, 35);
            button1.TabIndex = 12;
            button1.Text = "Sukurti";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 64, 0);
            button2.Location = new Point(161, 239);
            button2.Name = "button2";
            button2.Size = new Size(132, 35);
            button2.TabIndex = 13;
            button2.Text = "Pašalinti";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 192, 0);
            label6.Location = new Point(646, 109);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 14;
            label6.Text = "Grupė";
            // 
            // cmbGroups
            // 
            cmbGroups.FormattingEnabled = true;
            cmbGroups.Location = new Point(720, 109);
            cmbGroups.Name = "cmbGroups";
            cmbGroups.Size = new Size(121, 23);
            cmbGroups.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 16F);
            button3.ForeColor = Color.Yellow;
            button3.Location = new Point(798, 18);
            button3.Name = "button3";
            button3.Size = new Size(76, 41);
            button3.TabIndex = 16;
            button3.Text = "Atgal";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(900, 597);
            Controls.Add(button3);
            Controls.Add(cmbGroups);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label6;
        private ComboBox cmbGroups;
        private Button button3;
    }
}