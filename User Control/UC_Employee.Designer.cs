namespace HotelSoftware.User_Control
{
    partial class UC_Employee
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            heading_label = new Label();
            Emp_tabControll = new TabControl();
            employee_tabPage_regist = new TabPage();
            empGender_comboBox = new ComboBox();
            freeID_label = new Label();
            empRegister_button = new Button();
            empGender_label = new Label();
            empMobileNum_textBox = new TextBox();
            empMobileNum_label = new Label();
            empName_textBox = new TextBox();
            empName_label = new Label();
            empPassword_textBox = new TextBox();
            empPassword_label = new Label();
            empUserName_textBox = new TextBox();
            empUserName_label = new Label();
            empEmail_textBox = new TextBox();
            EmpEmail_label = new Label();
            id_label = new Label();
            employee_tabPage_details = new TabPage();
            label1 = new Label();
            empDetail_DataGridView = new DataGridView();
            employee_tabPage_delete = new TabPage();
            delEmployee_button = new Button();
            empDelete_DataGridView = new DataGridView();
            delID_textBox = new TextBox();
            deleteID_label = new Label();
            error_label = new Label();
            Emp_tabControll.SuspendLayout();
            employee_tabPage_regist.SuspendLayout();
            employee_tabPage_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empDetail_DataGridView).BeginInit();
            employee_tabPage_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empDelete_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // heading_label
            // 
            heading_label.AutoSize = true;
            heading_label.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point);
            heading_label.Location = new Point(15, 14);
            heading_label.Margin = new Padding(2, 0, 2, 0);
            heading_label.Name = "heading_label";
            heading_label.Size = new Size(133, 30);
            heading_label.TabIndex = 2;
            heading_label.Text = "Employee";
            // 
            // Emp_tabControll
            // 
            Emp_tabControll.Controls.Add(employee_tabPage_regist);
            Emp_tabControll.Controls.Add(employee_tabPage_details);
            Emp_tabControll.Controls.Add(employee_tabPage_delete);
            Emp_tabControll.Location = new Point(15, 59);
            Emp_tabControll.Name = "Emp_tabControll";
            Emp_tabControll.SelectedIndex = 0;
            Emp_tabControll.Size = new Size(938, 218);
            Emp_tabControll.TabIndex = 3;
            Emp_tabControll.SelectedIndexChanged += tabEmployee_selectedIndex;
            // 
            // employee_tabPage_regist
            // 
            employee_tabPage_regist.BackColor = Color.White;
            employee_tabPage_regist.BorderStyle = BorderStyle.Fixed3D;
            employee_tabPage_regist.Controls.Add(empGender_comboBox);
            employee_tabPage_regist.Controls.Add(freeID_label);
            employee_tabPage_regist.Controls.Add(empRegister_button);
            employee_tabPage_regist.Controls.Add(empGender_label);
            employee_tabPage_regist.Controls.Add(empMobileNum_textBox);
            employee_tabPage_regist.Controls.Add(empMobileNum_label);
            employee_tabPage_regist.Controls.Add(empName_textBox);
            employee_tabPage_regist.Controls.Add(empName_label);
            employee_tabPage_regist.Controls.Add(empPassword_textBox);
            employee_tabPage_regist.Controls.Add(empPassword_label);
            employee_tabPage_regist.Controls.Add(empUserName_textBox);
            employee_tabPage_regist.Controls.Add(empUserName_label);
            employee_tabPage_regist.Controls.Add(empEmail_textBox);
            employee_tabPage_regist.Controls.Add(EmpEmail_label);
            employee_tabPage_regist.Controls.Add(id_label);
            employee_tabPage_regist.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            employee_tabPage_regist.Location = new Point(4, 24);
            employee_tabPage_regist.Name = "employee_tabPage_regist";
            employee_tabPage_regist.Padding = new Padding(3);
            employee_tabPage_regist.Size = new Size(930, 190);
            employee_tabPage_regist.TabIndex = 0;
            employee_tabPage_regist.Text = "Employee registration";
            // 
            // empGender_comboBox
            // 
            empGender_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            empGender_comboBox.FlatStyle = FlatStyle.Popup;
            empGender_comboBox.FormattingEnabled = true;
            empGender_comboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            empGender_comboBox.Location = new Point(282, 140);
            empGender_comboBox.Margin = new Padding(2);
            empGender_comboBox.Name = "empGender_comboBox";
            empGender_comboBox.Size = new Size(193, 25);
            empGender_comboBox.TabIndex = 36;
            empGender_comboBox.SelectedIndexChanged += empGender_comboBox_SelectedIndexChanged;
            // 
            // freeID_label
            // 
            freeID_label.AutoSize = true;
            freeID_label.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            freeID_label.ForeColor = Color.FromArgb(19, 15, 64);
            freeID_label.Location = new Point(62, 15);
            freeID_label.Margin = new Padding(2, 0, 2, 0);
            freeID_label.Name = "freeID_label";
            freeID_label.Size = new Size(40, 22);
            freeID_label.TabIndex = 35;
            freeID_label.Text = "-----";
            // 
            // empRegister_button
            // 
            empRegister_button.BackColor = Color.FromArgb(19, 15, 64);
            empRegister_button.FlatAppearance.BorderColor = Color.White;
            empRegister_button.FlatAppearance.BorderSize = 2;
            empRegister_button.FlatStyle = FlatStyle.Popup;
            empRegister_button.ForeColor = Color.White;
            empRegister_button.Location = new Point(778, 149);
            empRegister_button.Margin = new Padding(2);
            empRegister_button.Name = "empRegister_button";
            empRegister_button.Size = new Size(133, 32);
            empRegister_button.TabIndex = 34;
            empRegister_button.Text = "Register";
            empRegister_button.UseVisualStyleBackColor = false;
            empRegister_button.Click += empRegister_button_Click;
            // 
            // empGender_label
            // 
            empGender_label.AutoSize = true;
            empGender_label.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empGender_label.ForeColor = Color.FromArgb(19, 15, 64);
            empGender_label.Location = new Point(282, 121);
            empGender_label.Margin = new Padding(2, 0, 2, 0);
            empGender_label.Name = "empGender_label";
            empGender_label.Size = new Size(53, 17);
            empGender_label.TabIndex = 20;
            empGender_label.Text = "Gender";
            // 
            // empMobileNum_textBox
            // 
            empMobileNum_textBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empMobileNum_textBox.Location = new Point(21, 140);
            empMobileNum_textBox.Margin = new Padding(2);
            empMobileNum_textBox.MaxLength = 35;
            empMobileNum_textBox.Name = "empMobileNum_textBox";
            empMobileNum_textBox.PlaceholderText = "Enter contact number";
            empMobileNum_textBox.Size = new Size(193, 22);
            empMobileNum_textBox.TabIndex = 19;
            empMobileNum_textBox.TextChanged += empMobileNum_textBox_TextChanged;
            empMobileNum_textBox.KeyPress += empMobileNumber_KeyPress;
            // 
            // empMobileNum_label
            // 
            empMobileNum_label.AutoSize = true;
            empMobileNum_label.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empMobileNum_label.ForeColor = Color.FromArgb(19, 15, 64);
            empMobileNum_label.Location = new Point(21, 121);
            empMobileNum_label.Margin = new Padding(2, 0, 2, 0);
            empMobileNum_label.Name = "empMobileNum_label";
            empMobileNum_label.Size = new Size(99, 17);
            empMobileNum_label.TabIndex = 18;
            empMobileNum_label.Text = "Mobile Number";
            // 
            // empName_textBox
            // 
            empName_textBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empName_textBox.Location = new Point(21, 71);
            empName_textBox.Margin = new Padding(2);
            empName_textBox.MaxLength = 35;
            empName_textBox.Name = "empName_textBox";
            empName_textBox.PlaceholderText = "Enter full name";
            empName_textBox.Size = new Size(193, 22);
            empName_textBox.TabIndex = 17;
            empName_textBox.TextChanged += empName_textBox_TextChanged;
            empName_textBox.KeyPress += empName_keyPress;
            // 
            // empName_label
            // 
            empName_label.AutoSize = true;
            empName_label.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empName_label.ForeColor = Color.FromArgb(19, 15, 64);
            empName_label.Location = new Point(21, 52);
            empName_label.Margin = new Padding(2, 0, 2, 0);
            empName_label.Name = "empName_label";
            empName_label.Size = new Size(44, 17);
            empName_label.TabIndex = 16;
            empName_label.Text = "Name";
            // 
            // empPassword_textBox
            // 
            empPassword_textBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empPassword_textBox.Location = new Point(547, 140);
            empPassword_textBox.Margin = new Padding(2);
            empPassword_textBox.MaxLength = 35;
            empPassword_textBox.Name = "empPassword_textBox";
            empPassword_textBox.PlaceholderText = "Enter secure password";
            empPassword_textBox.Size = new Size(193, 22);
            empPassword_textBox.TabIndex = 15;
            empPassword_textBox.UseSystemPasswordChar = true;
            empPassword_textBox.TextChanged += empPassword_textBox_TextChanged;
            // 
            // empPassword_label
            // 
            empPassword_label.AutoSize = true;
            empPassword_label.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empPassword_label.ForeColor = Color.FromArgb(19, 15, 64);
            empPassword_label.Location = new Point(547, 121);
            empPassword_label.Margin = new Padding(2, 0, 2, 0);
            empPassword_label.Name = "empPassword_label";
            empPassword_label.Size = new Size(63, 17);
            empPassword_label.TabIndex = 14;
            empPassword_label.Text = "Password";
            // 
            // empUserName_textBox
            // 
            empUserName_textBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empUserName_textBox.Location = new Point(547, 71);
            empUserName_textBox.Margin = new Padding(2);
            empUserName_textBox.MaxLength = 35;
            empUserName_textBox.Name = "empUserName_textBox";
            empUserName_textBox.PlaceholderText = "Enter full user name";
            empUserName_textBox.Size = new Size(193, 22);
            empUserName_textBox.TabIndex = 13;
            empUserName_textBox.TextChanged += empUserName_textBox_TextChanged;
            // 
            // empUserName_label
            // 
            empUserName_label.AutoSize = true;
            empUserName_label.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empUserName_label.ForeColor = Color.FromArgb(19, 15, 64);
            empUserName_label.Location = new Point(547, 52);
            empUserName_label.Margin = new Padding(2, 0, 2, 0);
            empUserName_label.Name = "empUserName_label";
            empUserName_label.Size = new Size(72, 17);
            empUserName_label.TabIndex = 12;
            empUserName_label.Text = "User Name";
            // 
            // empEmail_textBox
            // 
            empEmail_textBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            empEmail_textBox.Location = new Point(282, 71);
            empEmail_textBox.Margin = new Padding(2);
            empEmail_textBox.MaxLength = 35;
            empEmail_textBox.Name = "empEmail_textBox";
            empEmail_textBox.PlaceholderText = "Enter contact Mail";
            empEmail_textBox.Size = new Size(193, 22);
            empEmail_textBox.TabIndex = 11;
            empEmail_textBox.TextChanged += empEmail_textBox_TextChanged;
            // 
            // EmpEmail_label
            // 
            EmpEmail_label.AutoSize = true;
            EmpEmail_label.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmpEmail_label.ForeColor = Color.FromArgb(19, 15, 64);
            EmpEmail_label.Location = new Point(282, 52);
            EmpEmail_label.Margin = new Padding(2, 0, 2, 0);
            EmpEmail_label.Name = "EmpEmail_label";
            EmpEmail_label.Size = new Size(43, 17);
            EmpEmail_label.TabIndex = 10;
            EmpEmail_label.Text = "E-Mail";
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            id_label.ForeColor = Color.FromArgb(19, 15, 64);
            id_label.Location = new Point(21, 15);
            id_label.Margin = new Padding(2, 0, 2, 0);
            id_label.Name = "id_label";
            id_label.Size = new Size(27, 17);
            id_label.TabIndex = 8;
            id_label.Text = "ID -";
            // 
            // employee_tabPage_details
            // 
            employee_tabPage_details.BackColor = Color.White;
            employee_tabPage_details.BorderStyle = BorderStyle.Fixed3D;
            employee_tabPage_details.Controls.Add(label1);
            employee_tabPage_details.Controls.Add(empDetail_DataGridView);
            employee_tabPage_details.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            employee_tabPage_details.Location = new Point(4, 24);
            employee_tabPage_details.Name = "employee_tabPage_details";
            employee_tabPage_details.Padding = new Padding(3);
            employee_tabPage_details.Size = new Size(930, 190);
            employee_tabPage_details.TabIndex = 1;
            employee_tabPage_details.Text = "Employee details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(387, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 3;
            label1.Text = "Employee Details";
            // 
            // empDetail_DataGridView
            // 
            empDetail_DataGridView.BackgroundColor = Color.White;
            empDetail_DataGridView.BorderStyle = BorderStyle.Fixed3D;
            empDetail_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empDetail_DataGridView.Location = new Point(9, 50);
            empDetail_DataGridView.Name = "empDetail_DataGridView";
            empDetail_DataGridView.RowTemplate.Height = 25;
            empDetail_DataGridView.Size = new Size(911, 130);
            empDetail_DataGridView.TabIndex = 0;
            // 
            // employee_tabPage_delete
            // 
            employee_tabPage_delete.BackColor = Color.White;
            employee_tabPage_delete.BorderStyle = BorderStyle.Fixed3D;
            employee_tabPage_delete.Controls.Add(delEmployee_button);
            employee_tabPage_delete.Controls.Add(empDelete_DataGridView);
            employee_tabPage_delete.Controls.Add(delID_textBox);
            employee_tabPage_delete.Controls.Add(deleteID_label);
            employee_tabPage_delete.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            employee_tabPage_delete.Location = new Point(4, 24);
            employee_tabPage_delete.Name = "employee_tabPage_delete";
            employee_tabPage_delete.Size = new Size(930, 190);
            employee_tabPage_delete.TabIndex = 2;
            employee_tabPage_delete.Text = "Delete employee";
            // 
            // delEmployee_button
            // 
            delEmployee_button.BackColor = Color.FromArgb(19, 15, 64);
            delEmployee_button.FlatAppearance.BorderColor = Color.White;
            delEmployee_button.FlatAppearance.BorderSize = 2;
            delEmployee_button.FlatStyle = FlatStyle.Popup;
            delEmployee_button.ForeColor = Color.White;
            delEmployee_button.Location = new Point(686, 13);
            delEmployee_button.Margin = new Padding(2);
            delEmployee_button.Name = "delEmployee_button";
            delEmployee_button.Size = new Size(133, 32);
            delEmployee_button.TabIndex = 35;
            delEmployee_button.Text = "Delete";
            delEmployee_button.UseVisualStyleBackColor = false;
            delEmployee_button.Click += delEmployee_button_Click;
            // 
            // empDelete_DataGridView
            // 
            empDelete_DataGridView.BackgroundColor = Color.White;
            empDelete_DataGridView.BorderStyle = BorderStyle.Fixed3D;
            empDelete_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empDelete_DataGridView.Location = new Point(12, 53);
            empDelete_DataGridView.Name = "empDelete_DataGridView";
            empDelete_DataGridView.RowTemplate.Height = 25;
            empDelete_DataGridView.Size = new Size(911, 130);
            empDelete_DataGridView.TabIndex = 2;
            // 
            // delID_textBox
            // 
            delID_textBox.Location = new Point(330, 13);
            delID_textBox.Name = "delID_textBox";
            delID_textBox.PlaceholderText = "Enter employee ID";
            delID_textBox.Size = new Size(169, 26);
            delID_textBox.TabIndex = 1;
            delID_textBox.KeyPress += empDeleteID_KeyPress;
            // 
            // deleteID_label
            // 
            deleteID_label.AutoSize = true;
            deleteID_label.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteID_label.Location = new Point(283, 16);
            deleteID_label.Name = "deleteID_label";
            deleteID_label.Size = new Size(29, 20);
            deleteID_label.TabIndex = 0;
            deleteID_label.Text = "ID:";
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(367, 29);
            error_label.Name = "error_label";
            error_label.Size = new Size(411, 15);
            error_label.TabIndex = 36;
            error_label.Text = "Database currently not available. It is not possible to register a new employee";
            error_label.Visible = false;
            // 
            // UC_Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(error_label);
            Controls.Add(Emp_tabControll);
            Controls.Add(heading_label);
            Name = "UC_Employee";
            Size = new Size(956, 292);
            Load += UC_Employee_Load;
            Emp_tabControll.ResumeLayout(false);
            employee_tabPage_regist.ResumeLayout(false);
            employee_tabPage_regist.PerformLayout();
            employee_tabPage_details.ResumeLayout(false);
            employee_tabPage_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)empDetail_DataGridView).EndInit();
            employee_tabPage_delete.ResumeLayout(false);
            employee_tabPage_delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)empDelete_DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading_label;
        private TabControl Emp_tabControll;
        private TabPage employee_tabPage_regist;
        private TabPage employee_tabPage_details;
        private TabPage employee_tabPage_delete;
        private TextBox textBox6;
        private Label empGender_label;
        private TextBox empMobileNum_textBox;
        private Label empMobileNum_label;
        private TextBox empName_textBox;
        private Label empName_label;
        private TextBox empPassword_textBox;
        private Label empPassword_label;
        private TextBox empUserName_textBox;
        private Label empUserName_label;
        private TextBox empEmail_textBox;
        private Label EmpEmail_label;
        private Label id_label;
        private Label freeID_label;
        private Button empRegister_button;
        private ComboBox empGender_comboBox;
        private DataGridView empDetail_DataGridView;
        private Label label1;
        private Button delEmployee_button;
        private DataGridView empDelete_DataGridView;
        private TextBox delID_textBox;
        private Label deleteID_label;
        private Label error_label;
    }
}
