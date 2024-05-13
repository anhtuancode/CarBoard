namespace GUI
{
    partial class Setting
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
            groupBox2 = new GroupBox();
            btn_exit = new Button();
            btn_edit = new Button();
            btn_save_info = new Button();
            gb_user_info = new GroupBox();
            txt_id = new TextBox();
            label15 = new Label();
            cb_shift = new ComboBox();
            txt_name = new TextBox();
            txt_address = new RichTextBox();
            label4 = new Label();
            txt_coefficients_salary = new TextBox();
            txt_birth = new DateTimePicker();
            label11 = new Label();
            label5 = new Label();
            cb_gender = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_phone = new TextBox();
            txt_identity = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            gb_account = new GroupBox();
            show_password = new CheckBox();
            btn_save_account = new Button();
            btn_edit_info = new Button();
            label13 = new Label();
            cb_role = new ComboBox();
            txt_password = new TextBox();
            label12 = new Label();
            txt_user_name = new TextBox();
            label9 = new Label();
            txt_account_id = new TextBox();
            label2 = new Label();
            data_sales = new DataGridView();
            customer = new DataGridViewTextBoxColumn();
            car = new DataGridViewTextBoxColumn();
            revenue = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            gb_salary = new GroupBox();
            label14 = new Label();
            txt_salary = new TextBox();
            groupBox2.SuspendLayout();
            gb_user_info.SuspendLayout();
            panel1.SuspendLayout();
            gb_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_sales).BeginInit();
            gb_salary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btn_exit);
            groupBox2.Controls.Add(btn_edit);
            groupBox2.Controls.Add(btn_save_info);
            groupBox2.Location = new Point(1002, 78);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(280, 264);
            groupBox2.TabIndex = 79;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.SteelBlue;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.ForeColor = SystemColors.ButtonHighlight;
            btn_exit.Location = new Point(20, 103);
            btn_exit.Margin = new Padding(4, 4, 4, 4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(89, 32);
            btn_exit.TabIndex = 74;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.SteelBlue;
            btn_edit.Cursor = Cursors.Hand;
            btn_edit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = SystemColors.ButtonHighlight;
            btn_edit.Location = new Point(20, 34);
            btn_edit.Margin = new Padding(4, 4, 4, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(89, 32);
            btn_edit.TabIndex = 72;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_save_info
            // 
            btn_save_info.BackColor = Color.SteelBlue;
            btn_save_info.Cursor = Cursors.Hand;
            btn_save_info.Enabled = false;
            btn_save_info.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save_info.ForeColor = SystemColors.ButtonHighlight;
            btn_save_info.Location = new Point(20, 68);
            btn_save_info.Margin = new Padding(4, 4, 4, 4);
            btn_save_info.Name = "btn_save_info";
            btn_save_info.Size = new Size(89, 32);
            btn_save_info.TabIndex = 73;
            btn_save_info.Text = "Save";
            btn_save_info.UseVisualStyleBackColor = false;
            btn_save_info.Click += btn_save_info_Click;
            // 
            // gb_user_info
            // 
            gb_user_info.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_user_info.Controls.Add(txt_id);
            gb_user_info.Controls.Add(label15);
            gb_user_info.Controls.Add(cb_shift);
            gb_user_info.Controls.Add(txt_name);
            gb_user_info.Controls.Add(txt_address);
            gb_user_info.Controls.Add(label4);
            gb_user_info.Controls.Add(txt_coefficients_salary);
            gb_user_info.Controls.Add(txt_birth);
            gb_user_info.Controls.Add(label11);
            gb_user_info.Controls.Add(label5);
            gb_user_info.Controls.Add(cb_gender);
            gb_user_info.Controls.Add(label3);
            gb_user_info.Controls.Add(label6);
            gb_user_info.Controls.Add(label10);
            gb_user_info.Controls.Add(label7);
            gb_user_info.Controls.Add(label8);
            gb_user_info.Controls.Add(txt_phone);
            gb_user_info.Controls.Add(txt_identity);
            gb_user_info.Location = new Point(13, 78);
            gb_user_info.Margin = new Padding(2);
            gb_user_info.Name = "gb_user_info";
            gb_user_info.Padding = new Padding(2);
            gb_user_info.Size = new Size(1228, 264);
            gb_user_info.TabIndex = 78;
            gb_user_info.TabStop = false;
            gb_user_info.Text = "User infomations";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.ForeColor = Color.Black;
            txt_id.Location = new Point(95, 25);
            txt_id.Margin = new Padding(4, 4, 4, 4);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(840, 23);
            txt_id.TabIndex = 72;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(39, 26);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(25, 17);
            label15.TabIndex = 71;
            label15.Text = "ID:";
            // 
            // cb_shift
            // 
            cb_shift.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_shift.Enabled = false;
            cb_shift.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            cb_shift.ForeColor = Color.Black;
            cb_shift.FormattingEnabled = true;
            cb_shift.Items.AddRange(new object[] { "Morning", "Afternoon", "Night" });
            cb_shift.Location = new Point(376, 132);
            cb_shift.Margin = new Padding(2);
            cb_shift.Name = "cb_shift";
            cb_shift.Size = new Size(205, 24);
            cb_shift.TabIndex = 70;
            // 
            // txt_name
            // 
            txt_name.Enabled = false;
            txt_name.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.ForeColor = Color.Black;
            txt_name.Location = new Point(98, 58);
            txt_name.Margin = new Padding(4, 4, 4, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(196, 23);
            txt_name.TabIndex = 54;
            // 
            // txt_address
            // 
            txt_address.Enabled = false;
            txt_address.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.ForeColor = Color.Black;
            txt_address.Location = new Point(665, 99);
            txt_address.Margin = new Padding(2);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(271, 50);
            txt_address.TabIndex = 69;
            txt_address.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(39, 59);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 44;
            label4.Text = "Name";
            // 
            // txt_coefficients_salary
            // 
            txt_coefficients_salary.Enabled = false;
            txt_coefficients_salary.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txt_coefficients_salary.ForeColor = Color.Black;
            txt_coefficients_salary.Location = new Point(723, 60);
            txt_coefficients_salary.Margin = new Padding(4, 4, 4, 4);
            txt_coefficients_salary.Name = "txt_coefficients_salary";
            txt_coefficients_salary.Size = new Size(213, 23);
            txt_coefficients_salary.TabIndex = 66;
            txt_coefficients_salary.KeyPress += txt_coefficients_salary_presskey;
            // 
            // txt_birth
            // 
            txt_birth.CalendarFont = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txt_birth.CustomFormat = "yyyy/MM/dd";
            txt_birth.Enabled = false;
            txt_birth.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txt_birth.Location = new Point(98, 133);
            txt_birth.Margin = new Padding(2);
            txt_birth.Name = "txt_birth";
            txt_birth.Size = new Size(196, 23);
            txt_birth.TabIndex = 68;
            txt_birth.Value = new DateTime(2023, 5, 5, 23, 0, 25, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(589, 61);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(123, 17);
            label11.TabIndex = 65;
            label11.Text = "Coefficients salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(39, 99);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 45;
            label5.Text = "Gender";
            // 
            // cb_gender
            // 
            cb_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_gender.Enabled = false;
            cb_gender.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            cb_gender.ForeColor = Color.Black;
            cb_gender.FormattingEnabled = true;
            cb_gender.Items.AddRange(new object[] { "Male", "Female" });
            cb_gender.Location = new Point(98, 97);
            cb_gender.Margin = new Padding(2);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(196, 24);
            cb_gender.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(314, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 63;
            label3.Text = "Shift";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(39, 134);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 17);
            label6.TabIndex = 46;
            label6.Text = "Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(589, 98);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 17);
            label10.TabIndex = 61;
            label10.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(314, 60);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 47;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(314, 98);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 17);
            label8.TabIndex = 48;
            label8.Text = "Identity";
            // 
            // txt_phone
            // 
            txt_phone.Enabled = false;
            txt_phone.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.ForeColor = Color.Black;
            txt_phone.Location = new Point(376, 59);
            txt_phone.Margin = new Padding(4, 4, 4, 4);
            txt_phone.MaxLength = 10;
            txt_phone.Name = "txt_phone";
            txt_phone.ScrollBars = ScrollBars.Horizontal;
            txt_phone.Size = new Size(205, 23);
            txt_phone.TabIndex = 57;
            txt_phone.KeyPress += txt_phone_presskey;
            // 
            // txt_identity
            // 
            txt_identity.Enabled = false;
            txt_identity.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txt_identity.ForeColor = Color.Black;
            txt_identity.Location = new Point(376, 97);
            txt_identity.Margin = new Padding(4, 4, 4, 4);
            txt_identity.Name = "txt_identity";
            txt_identity.ScrollBars = ScrollBars.Horizontal;
            txt_identity.Size = new Size(205, 23);
            txt_identity.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1293, 67);
            panel1.TabIndex = 76;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(510, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 2;
            label1.Text = "Setting";
            // 
            // gb_account
            // 
            gb_account.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_account.Controls.Add(show_password);
            gb_account.Controls.Add(btn_save_account);
            gb_account.Controls.Add(btn_edit_info);
            gb_account.Controls.Add(label13);
            gb_account.Controls.Add(cb_role);
            gb_account.Controls.Add(txt_password);
            gb_account.Controls.Add(label12);
            gb_account.Controls.Add(txt_user_name);
            gb_account.Controls.Add(label9);
            gb_account.Controls.Add(txt_account_id);
            gb_account.Controls.Add(label2);
            gb_account.Location = new Point(13, 244);
            gb_account.Margin = new Padding(2);
            gb_account.Name = "gb_account";
            gb_account.Padding = new Padding(2);
            gb_account.Size = new Size(873, 341);
            gb_account.TabIndex = 80;
            gb_account.TabStop = false;
            gb_account.Text = "Account";
            // 
            // show_password
            // 
            show_password.AutoSize = true;
            show_password.Location = new Point(133, 166);
            show_password.Margin = new Padding(2);
            show_password.Name = "show_password";
            show_password.Size = new Size(108, 19);
            show_password.TabIndex = 74;
            show_password.Text = "Show password";
            show_password.UseVisualStyleBackColor = true;
            show_password.CheckedChanged += show_password_CheckedChanged;
            // 
            // btn_save_account
            // 
            btn_save_account.BackColor = Color.SteelBlue;
            btn_save_account.Cursor = Cursors.Hand;
            btn_save_account.Enabled = false;
            btn_save_account.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save_account.ForeColor = SystemColors.ButtonHighlight;
            btn_save_account.Location = new Point(475, 202);
            btn_save_account.Margin = new Padding(4, 4, 4, 4);
            btn_save_account.Name = "btn_save_account";
            btn_save_account.Size = new Size(89, 32);
            btn_save_account.TabIndex = 73;
            btn_save_account.Text = "Save";
            btn_save_account.UseVisualStyleBackColor = false;
            btn_save_account.Click += btn_save_account_Click;
            // 
            // btn_edit_info
            // 
            btn_edit_info.BackColor = Color.SteelBlue;
            btn_edit_info.Cursor = Cursors.Hand;
            btn_edit_info.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit_info.ForeColor = SystemColors.ButtonHighlight;
            btn_edit_info.Location = new Point(380, 202);
            btn_edit_info.Margin = new Padding(4, 4, 4, 4);
            btn_edit_info.Name = "btn_edit_info";
            btn_edit_info.Size = new Size(89, 32);
            btn_edit_info.TabIndex = 72;
            btn_edit_info.Text = "Edit";
            btn_edit_info.UseVisualStyleBackColor = false;
            btn_edit_info.Click += btn_edit_info_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(312, 143);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(41, 17);
            label13.TabIndex = 68;
            label13.Text = "Role:";
            // 
            // cb_role
            // 
            cb_role.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_role.Enabled = false;
            cb_role.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_role.ForeColor = Color.Black;
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "ADMIN", "STAFF" });
            cb_role.Location = new Point(370, 141);
            cb_role.Margin = new Padding(2);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(196, 28);
            cb_role.TabIndex = 69;
            // 
            // txt_password
            // 
            txt_password.Enabled = false;
            txt_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = Color.Black;
            txt_password.Location = new Point(133, 140);
            txt_password.Margin = new Padding(4, 4, 4, 4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(159, 26);
            txt_password.TabIndex = 60;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(37, 143);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(73, 17);
            label12.TabIndex = 59;
            label12.Text = "Password:";
            // 
            // txt_user_name
            // 
            txt_user_name.Enabled = false;
            txt_user_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user_name.ForeColor = Color.Black;
            txt_user_name.Location = new Point(133, 105);
            txt_user_name.Margin = new Padding(4, 4, 4, 4);
            txt_user_name.Name = "txt_user_name";
            txt_user_name.Size = new Size(433, 26);
            txt_user_name.TabIndex = 58;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(37, 108);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 17);
            label9.TabIndex = 57;
            label9.Text = "User name:";
            // 
            // txt_account_id
            // 
            txt_account_id.Enabled = false;
            txt_account_id.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_account_id.ForeColor = Color.Black;
            txt_account_id.Location = new Point(78, 72);
            txt_account_id.Margin = new Padding(4, 4, 4, 4);
            txt_account_id.Name = "txt_account_id";
            txt_account_id.Size = new Size(488, 26);
            txt_account_id.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(37, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 17);
            label2.TabIndex = 55;
            label2.Text = "ID:";
            // 
            // data_sales
            // 
            data_sales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            data_sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_sales.Columns.AddRange(new DataGridViewColumn[] { customer, car, revenue, status });
            data_sales.Location = new Point(4, 62);
            data_sales.Margin = new Padding(2);
            data_sales.Name = "data_sales";
            data_sales.RowHeadersWidth = 82;
            data_sales.RowTemplate.Height = 41;
            data_sales.Size = new Size(625, 275);
            data_sales.TabIndex = 81;
            // 
            // customer
            // 
            customer.HeaderText = "Customer";
            customer.MinimumWidth = 10;
            customer.Name = "customer";
            customer.Width = 200;
            // 
            // car
            // 
            car.HeaderText = "Car";
            car.MinimumWidth = 10;
            car.Name = "car";
            car.Width = 200;
            // 
            // revenue
            // 
            revenue.HeaderText = "Revenue";
            revenue.MinimumWidth = 10;
            revenue.Name = "revenue";
            revenue.Width = 200;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 10;
            status.Name = "status";
            status.Width = 200;
            // 
            // gb_salary
            // 
            gb_salary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gb_salary.Controls.Add(label14);
            gb_salary.Controls.Add(data_sales);
            gb_salary.Controls.Add(txt_salary);
            gb_salary.Location = new Point(648, 244);
            gb_salary.Margin = new Padding(2);
            gb_salary.Name = "gb_salary";
            gb_salary.Padding = new Padding(2);
            gb_salary.Size = new Size(634, 341);
            gb_salary.TabIndex = 82;
            gb_salary.TabStop = false;
            gb_salary.Text = "Salary";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(73, 33);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(52, 17);
            label14.TabIndex = 58;
            label14.Text = "Salary:";
            // 
            // txt_salary
            // 
            txt_salary.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_salary.ForeColor = Color.Black;
            txt_salary.Location = new Point(135, 30);
            txt_salary.Margin = new Padding(4, 4, 4, 4);
            txt_salary.Name = "txt_salary";
            txt_salary.ReadOnly = true;
            txt_salary.ScrollBars = ScrollBars.Horizontal;
            txt_salary.Size = new Size(280, 26);
            txt_salary.TabIndex = 59;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1293, 596);
            Controls.Add(gb_salary);
            Controls.Add(gb_account);
            Controls.Add(groupBox2);
            Controls.Add(gb_user_info);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Setting";
            Text = "Setting";
            groupBox2.ResumeLayout(false);
            gb_user_info.ResumeLayout(false);
            gb_user_info.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gb_account.ResumeLayout(false);
            gb_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_sales).EndInit();
            gb_salary.ResumeLayout(false);
            gb_salary.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupBox2;
        private Button btn_exit;
        private Button btn_edit;
        private GroupBox gb_user_info;
        private TextBox txt_name;
        private RichTextBox txt_address;
        private Label label4;
        private TextBox txt_coefficients_salary;
        private DateTimePicker txt_birth;
        private Label label11;
        private Label label5;
        private ComboBox cb_gender;
        private Label label3;
        private Label label6;
        private Label label10;
        private Label label7;
        private Label label8;
        private TextBox txt_phone;
        private TextBox txt_identity;
        private Panel panel1;
        private Label label1;
        private GroupBox gb_account;
        private Button btn_save_account;
        private Button btn_edit_info;
        private Label label13;
        private ComboBox cb_role;
        private TextBox txt_password;
        private Label label12;
        private TextBox txt_user_name;
        private Label label9;
        private TextBox txt_account_id;
        private Label label2;
        private Button btn_save_info;
        private DataGridView data_sales;
        private ComboBox cb_shift;
        private GroupBox gb_salary;
        private Label label14;
        private TextBox txt_salary;
        private TextBox txt_id;
        private Label label15;
        private CheckBox show_password;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn car;
        private DataGridViewTextBoxColumn revenue;
        private DataGridViewTextBoxColumn status;
    }
}