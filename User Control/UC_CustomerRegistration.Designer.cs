namespace HotelSoftware.User_Control
{
    partial class UC_CustomerRegistration
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
            name_label = new Label();
            phoneNumber_label = new Label();
            nationality_label = new Label();
            gender_label = new Label();
            name_textBox = new TextBox();
            phoneNumber_textBox = new TextBox();
            nationality_textBox = new TextBox();
            birthday_label = new Label();
            birthday_dateTimePicker = new DateTimePicker();
            gender_comboBox = new ComboBox();
            address_textBox = new TextBox();
            id_textBox = new TextBox();
            checkIn_label = new Label();
            address_label = new Label();
            id_label = new Label();
            checkIn_dateTimePicker = new DateTimePicker();
            price_label = new Label();
            roomNumber_label = new Label();
            roomType_label = new Label();
            service_label = new Label();
            service_comboBox = new ComboBox();
            roomType_comboBox = new ComboBox();
            roomNumber_comboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            price_textBox = new TextBox();
            alloteRoom_button = new Button();
            database_error_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // heading_label
            // 
            heading_label.AutoSize = true;
            heading_label.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point);
            heading_label.Location = new Point(15, 14);
            heading_label.Margin = new Padding(2, 0, 2, 0);
            heading_label.Name = "heading_label";
            heading_label.Size = new Size(275, 30);
            heading_label.TabIndex = 1;
            heading_label.Text = "Customer Registration";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            name_label.ForeColor = Color.FromArgb(19, 15, 64);
            name_label.Location = new Point(15, 60);
            name_label.Margin = new Padding(2, 0, 2, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(58, 19);
            name_label.TabIndex = 3;
            name_label.Text = "Name";
            // 
            // phoneNumber_label
            // 
            phoneNumber_label.AutoSize = true;
            phoneNumber_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            phoneNumber_label.ForeColor = Color.FromArgb(19, 15, 64);
            phoneNumber_label.Location = new Point(15, 119);
            phoneNumber_label.Margin = new Padding(2, 0, 2, 0);
            phoneNumber_label.Name = "phoneNumber_label";
            phoneNumber_label.Size = new Size(123, 19);
            phoneNumber_label.TabIndex = 4;
            phoneNumber_label.Text = "Phone number";
            // 
            // nationality_label
            // 
            nationality_label.AutoSize = true;
            nationality_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            nationality_label.ForeColor = Color.FromArgb(19, 15, 64);
            nationality_label.Location = new Point(15, 230);
            nationality_label.Margin = new Padding(2, 0, 2, 0);
            nationality_label.Name = "nationality_label";
            nationality_label.Size = new Size(98, 19);
            nationality_label.TabIndex = 5;
            nationality_label.Text = "Nationality";
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            gender_label.ForeColor = Color.FromArgb(19, 15, 64);
            gender_label.Location = new Point(15, 177);
            gender_label.Margin = new Padding(2, 0, 2, 0);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(69, 19);
            gender_label.TabIndex = 6;
            gender_label.Text = "Gender";
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(15, 84);
            name_textBox.Margin = new Padding(2);
            name_textBox.MaxLength = 35;
            name_textBox.Name = "name_textBox";
            name_textBox.PlaceholderText = "Enter full name";
            name_textBox.Size = new Size(193, 23);
            name_textBox.TabIndex = 7;
            name_textBox.TextChanged += name_textBox_TextChanged;
            name_textBox.KeyPress += name_textbox_KeyPress;
            // 
            // phoneNumber_textBox
            // 
            phoneNumber_textBox.Location = new Point(15, 142);
            phoneNumber_textBox.Margin = new Padding(2);
            phoneNumber_textBox.MaxLength = 12;
            phoneNumber_textBox.Name = "phoneNumber_textBox";
            phoneNumber_textBox.PlaceholderText = "Enter phone number";
            phoneNumber_textBox.Size = new Size(193, 23);
            phoneNumber_textBox.TabIndex = 8;
            phoneNumber_textBox.TextChanged += phoneNumber_textBox_TextChanged;
            phoneNumber_textBox.KeyPress += phoneNumber_textBox_KeyPress;
            // 
            // nationality_textBox
            // 
            nationality_textBox.Location = new Point(15, 257);
            nationality_textBox.Margin = new Padding(2);
            nationality_textBox.MaxLength = 15;
            nationality_textBox.Name = "nationality_textBox";
            nationality_textBox.PlaceholderText = "Nationality";
            nationality_textBox.Size = new Size(193, 23);
            nationality_textBox.TabIndex = 9;
            nationality_textBox.TextChanged += nationality_textBox_TextChanged;
            nationality_textBox.KeyPress += nationality_textBox_KeyPress;
            // 
            // birthday_label
            // 
            birthday_label.AutoSize = true;
            birthday_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            birthday_label.ForeColor = Color.FromArgb(19, 15, 64);
            birthday_label.Location = new Point(354, 60);
            birthday_label.Margin = new Padding(2, 0, 2, 0);
            birthday_label.Name = "birthday_label";
            birthday_label.Size = new Size(112, 19);
            birthday_label.TabIndex = 11;
            birthday_label.Text = "Date of birth";
            // 
            // birthday_dateTimePicker
            // 
            birthday_dateTimePicker.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            birthday_dateTimePicker.Format = DateTimePickerFormat.Short;
            birthday_dateTimePicker.Location = new Point(354, 84);
            birthday_dateTimePicker.Margin = new Padding(2);
            birthday_dateTimePicker.Name = "birthday_dateTimePicker";
            birthday_dateTimePicker.Size = new Size(200, 25);
            birthday_dateTimePicker.TabIndex = 12;
            // 
            // gender_comboBox
            // 
            gender_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gender_comboBox.FlatStyle = FlatStyle.Popup;
            gender_comboBox.FormattingEnabled = true;
            gender_comboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            gender_comboBox.Location = new Point(15, 198);
            gender_comboBox.Margin = new Padding(2);
            gender_comboBox.Name = "gender_comboBox";
            gender_comboBox.Size = new Size(193, 23);
            gender_comboBox.TabIndex = 13;
            gender_comboBox.SelectedIndexChanged += gender_comboBox_SelectedIndexChanged;
            // 
            // address_textBox
            // 
            address_textBox.Location = new Point(354, 198);
            address_textBox.Margin = new Padding(2);
            address_textBox.MaxLength = 50;
            address_textBox.Name = "address_textBox";
            address_textBox.PlaceholderText = "Enter address";
            address_textBox.Size = new Size(193, 23);
            address_textBox.TabIndex = 18;
            address_textBox.TextChanged += address_textBox_TextChanged;
            // 
            // id_textBox
            // 
            id_textBox.Location = new Point(354, 142);
            id_textBox.Margin = new Padding(2);
            id_textBox.MaxLength = 6;
            id_textBox.Name = "id_textBox";
            id_textBox.PlaceholderText = "Enter id";
            id_textBox.Size = new Size(193, 23);
            id_textBox.TabIndex = 17;
            id_textBox.TextChanged += id_textBox_TextChanged;
            // 
            // checkIn_label
            // 
            checkIn_label.AutoSize = true;
            checkIn_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkIn_label.ForeColor = Color.FromArgb(19, 15, 64);
            checkIn_label.Location = new Point(354, 230);
            checkIn_label.Margin = new Padding(2, 0, 2, 0);
            checkIn_label.Name = "checkIn_label";
            checkIn_label.Size = new Size(78, 19);
            checkIn_label.TabIndex = 16;
            checkIn_label.Text = "Check in";
            // 
            // address_label
            // 
            address_label.AutoSize = true;
            address_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            address_label.ForeColor = Color.FromArgb(19, 15, 64);
            address_label.Location = new Point(354, 177);
            address_label.Margin = new Padding(2, 0, 2, 0);
            address_label.Name = "address_label";
            address_label.Size = new Size(70, 19);
            address_label.TabIndex = 15;
            address_label.Text = "Address";
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            id_label.ForeColor = Color.FromArgb(19, 15, 64);
            id_label.Location = new Point(354, 119);
            id_label.Margin = new Padding(2, 0, 2, 0);
            id_label.Name = "id_label";
            id_label.Size = new Size(69, 19);
            id_label.TabIndex = 14;
            id_label.Text = "ID Proof";
            // 
            // checkIn_dateTimePicker
            // 
            checkIn_dateTimePicker.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            checkIn_dateTimePicker.Format = DateTimePickerFormat.Short;
            checkIn_dateTimePicker.Location = new Point(354, 255);
            checkIn_dateTimePicker.Margin = new Padding(2);
            checkIn_dateTimePicker.Name = "checkIn_dateTimePicker";
            checkIn_dateTimePicker.Size = new Size(200, 25);
            checkIn_dateTimePicker.TabIndex = 19;
            checkIn_dateTimePicker.ValueChanged += checkIn_dateTimePicker_ValueChanged;
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            price_label.ForeColor = Color.FromArgb(19, 15, 64);
            price_label.Location = new Point(726, 188);
            price_label.Margin = new Padding(2, 0, 2, 0);
            price_label.Name = "price_label";
            price_label.Size = new Size(47, 19);
            price_label.TabIndex = 23;
            price_label.Text = "Price";
            // 
            // roomNumber_label
            // 
            roomNumber_label.AutoSize = true;
            roomNumber_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            roomNumber_label.ForeColor = Color.FromArgb(19, 15, 64);
            roomNumber_label.Location = new Point(726, 146);
            roomNumber_label.Margin = new Padding(2, 0, 2, 0);
            roomNumber_label.Name = "roomNumber_label";
            roomNumber_label.Size = new Size(122, 19);
            roomNumber_label.TabIndex = 22;
            roomNumber_label.Text = "Room Number";
            // 
            // roomType_label
            // 
            roomType_label.AutoSize = true;
            roomType_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            roomType_label.ForeColor = Color.FromArgb(19, 15, 64);
            roomType_label.Location = new Point(726, 60);
            roomType_label.Margin = new Padding(2, 0, 2, 0);
            roomType_label.Name = "roomType_label";
            roomType_label.Size = new Size(95, 19);
            roomType_label.TabIndex = 21;
            roomType_label.Text = "Room type";
            // 
            // service_label
            // 
            service_label.AutoSize = true;
            service_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            service_label.ForeColor = Color.FromArgb(19, 15, 64);
            service_label.Location = new Point(726, 102);
            service_label.Margin = new Padding(2, 0, 2, 0);
            service_label.Name = "service_label";
            service_label.Size = new Size(113, 19);
            service_label.TabIndex = 20;
            service_label.Text = "Room service";
            // 
            // service_comboBox
            // 
            service_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            service_comboBox.FlatStyle = FlatStyle.Popup;
            service_comboBox.FormattingEnabled = true;
            service_comboBox.Items.AddRange(new object[] { "None", "Half board", "Full board", "All-inclusive" });
            service_comboBox.Location = new Point(726, 119);
            service_comboBox.Margin = new Padding(2);
            service_comboBox.Name = "service_comboBox";
            service_comboBox.Size = new Size(193, 23);
            service_comboBox.TabIndex = 28;
            service_comboBox.SelectedIndexChanged += service_comboBox_SelectedIndexChanged;
            // 
            // roomType_comboBox
            // 
            roomType_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomType_comboBox.FlatStyle = FlatStyle.Popup;
            roomType_comboBox.FormattingEnabled = true;
            roomType_comboBox.Items.AddRange(new object[] { "Standard", "Twin room", "Deluxe twin room", "Junior Suite", "Presidental Suite" });
            roomType_comboBox.Location = new Point(726, 79);
            roomType_comboBox.Margin = new Padding(2);
            roomType_comboBox.Name = "roomType_comboBox";
            roomType_comboBox.Size = new Size(193, 23);
            roomType_comboBox.TabIndex = 29;
            roomType_comboBox.SelectedIndexChanged += roomType_comboBox_SelectedIndexChanged;
            // 
            // roomNumber_comboBox
            // 
            roomNumber_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomNumber_comboBox.FlatStyle = FlatStyle.Popup;
            roomNumber_comboBox.FormattingEnabled = true;
            roomNumber_comboBox.Location = new Point(726, 163);
            roomNumber_comboBox.Margin = new Padding(2);
            roomNumber_comboBox.Name = "roomNumber_comboBox";
            roomNumber_comboBox.Size = new Size(193, 23);
            roomNumber_comboBox.TabIndex = 30;
            roomNumber_comboBox.SelectedIndexChanged += roomNumber_comboBox_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.customer_registration;
            pictureBox1.Location = new Point(867, 230);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // price_textBox
            // 
            price_textBox.Location = new Point(726, 206);
            price_textBox.Margin = new Padding(2);
            price_textBox.MaxLength = 6;
            price_textBox.Name = "price_textBox";
            price_textBox.PlaceholderText = "Enter price";
            price_textBox.Size = new Size(193, 23);
            price_textBox.TabIndex = 32;
            price_textBox.TextChanged += price_textBox_TextChanged;
            price_textBox.KeyPress += price_textBox_KeyPress;
            // 
            // alloteRoom_button
            // 
            alloteRoom_button.BackColor = Color.FromArgb(19, 15, 64);
            alloteRoom_button.FlatAppearance.BorderColor = Color.White;
            alloteRoom_button.FlatAppearance.BorderSize = 2;
            alloteRoom_button.FlatStyle = FlatStyle.Popup;
            alloteRoom_button.ForeColor = Color.White;
            alloteRoom_button.Location = new Point(726, 248);
            alloteRoom_button.Margin = new Padding(2);
            alloteRoom_button.Name = "alloteRoom_button";
            alloteRoom_button.Size = new Size(133, 32);
            alloteRoom_button.TabIndex = 33;
            alloteRoom_button.Text = "Allote Room";
            alloteRoom_button.UseVisualStyleBackColor = false;
            alloteRoom_button.Click += alloteRoom_button_Click;
            // 
            // database_error_label
            // 
            database_error_label.AutoSize = true;
            database_error_label.Font = new Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point);
            database_error_label.ForeColor = Color.Red;
            database_error_label.Location = new Point(277, 272);
            database_error_label.Name = "database_error_label";
            database_error_label.Size = new Size(0, 17);
            database_error_label.TabIndex = 34;
            // 
            // UC_CustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(database_error_label);
            Controls.Add(alloteRoom_button);
            Controls.Add(price_textBox);
            Controls.Add(pictureBox1);
            Controls.Add(roomNumber_comboBox);
            Controls.Add(roomType_comboBox);
            Controls.Add(service_comboBox);
            Controls.Add(price_label);
            Controls.Add(roomNumber_label);
            Controls.Add(roomType_label);
            Controls.Add(service_label);
            Controls.Add(checkIn_dateTimePicker);
            Controls.Add(address_textBox);
            Controls.Add(id_textBox);
            Controls.Add(checkIn_label);
            Controls.Add(address_label);
            Controls.Add(id_label);
            Controls.Add(gender_comboBox);
            Controls.Add(birthday_dateTimePicker);
            Controls.Add(birthday_label);
            Controls.Add(nationality_textBox);
            Controls.Add(phoneNumber_textBox);
            Controls.Add(name_textBox);
            Controls.Add(gender_label);
            Controls.Add(nationality_label);
            Controls.Add(phoneNumber_label);
            Controls.Add(name_label);
            Controls.Add(heading_label);
            Margin = new Padding(2);
            Name = "UC_CustomerRegistration";
            Size = new Size(956, 292);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading_label;
        private Label name_label;
        private Label phoneNumber_label;
        private Label nationality_label;
        private Label gender_label;
        private TextBox name_textBox;
        private TextBox phoneNumber_textBox;
        private TextBox nationality_textBox;
        private Label birthday_label;
        private DateTimePicker birthday_dateTimePicker;
        private ComboBox gender_comboBox;
        private TextBox address_textBox;
        private TextBox id_textBox;
        private Label checkIn_label;
        private Label address_label;
        private Label id_label;
        private DateTimePicker checkIn_dateTimePicker;
        private Label price_label;
        private Label roomNumber_label;
        private Label roomType_label;
        private Label service_label;
        private ComboBox service_comboBox;
        private ComboBox roomType_comboBox;
        private ComboBox roomNumber_comboBox;
        private PictureBox pictureBox1;
        private TextBox price_textBox;
        private Button alloteRoom_button;
        private Label database_error_label;
    }
}
