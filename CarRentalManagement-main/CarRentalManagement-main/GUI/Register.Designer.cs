namespace GUI
{
    partial class register
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
            txtUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            registerbtn = new Button();
            txtComPassword = new TextBox();
            button2 = new Button();
            button3 = new Button();
            Showpassword = new CheckBox();
            txtPassword = new TextBox();
            label5 = new Label();
            txtStaff = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(248, 34);
            label1.Name = "label1";
            label1.Size = new Size(201, 42);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 94);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(248, 94);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 25);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 158);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 221);
            label4.Name = "label4";
            label4.Size = new Size(169, 23);
            label4.TabIndex = 6;
            label4.Text = "Confirm password:";
            label4.Click += label4_Click;
            // 
            // registerbtn
            // 
            registerbtn.BackColor = Color.FromArgb(116, 86, 174);
            registerbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerbtn.ForeColor = Color.GhostWhite;
            registerbtn.Location = new Point(139, 324);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(143, 54);
            registerbtn.TabIndex = 7;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = false;
            registerbtn.Click += button1_Click;
            // 
            // txtComPassword
            // 
            txtComPassword.Location = new Point(250, 220);
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new Size(199, 25);
            txtComPassword.TabIndex = 11;
            txtComPassword.TextChanged += txtComPassword_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(542, 442);
            button2.Name = "button2";
            button2.Size = new Size(8, 7);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(116, 86, 174);
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(465, 324);
            button3.Name = "button3";
            button3.Size = new Size(164, 54);
            button3.TabIndex = 13;
            button3.Text = "Back to login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Showpassword
            // 
            Showpassword.AutoSize = true;
            Showpassword.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Showpassword.Location = new Point(465, 295);
            Showpassword.Name = "Showpassword";
            Showpassword.Size = new Size(137, 23);
            Showpassword.TabIndex = 14;
            Showpassword.Text = "Show Password";
            Showpassword.UseVisualStyleBackColor = true;
            Showpassword.CheckedChanged += Showpassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(250, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(199, 25);
            txtPassword.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 269);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 16;
            label5.Text = "Role:";
            // 
            // txtStaff
            // 
            txtStaff.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaff.Location = new Point(248, 266);
            txtStaff.Name = "txtStaff";
            txtStaff.Size = new Size(199, 34);
            txtStaff.TabIndex = 17;
            txtStaff.Text = "           Staff";
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 388);
            Controls.Add(txtStaff);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(Showpassword);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtComPassword);
            Controls.Add(registerbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "register";
            Text = "Register";
            Load += cccd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Label label4;
        private Button registerbtn;
        private TextBox txtComPassword;
        private Button button2;
        private Button button3;
        private CheckBox Showpassword;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtStaff;
    }
}