namespace HotelSoftware.User_Control
{
    partial class UC_AddRooms
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
            addRoom_dataGridView = new DataGridView();
            roomNumber_label = new Label();
            roomType_label = new Label();
            options_label = new Label();
            price_label = new Label();
            roomNumber_textBox = new TextBox();
            options_comboBox = new ComboBox();
            roomType_comboBox = new ComboBox();
            addRoom_button = new Button();
            price_textBox = new TextBox();
            database_error_label = new Label();
            ((System.ComponentModel.ISupportInitialize)addRoom_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // heading_label
            // 
            heading_label.AutoSize = true;
            heading_label.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point);
            heading_label.Location = new Point(15, 14);
            heading_label.Margin = new Padding(2, 0, 2, 0);
            heading_label.Name = "heading_label";
            heading_label.Size = new Size(198, 30);
            heading_label.TabIndex = 0;
            heading_label.Text = "Add new Room";
            // 
            // addRoom_dataGridView
            // 
            addRoom_dataGridView.BackgroundColor = Color.White;
            addRoom_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            addRoom_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addRoom_dataGridView.Location = new Point(15, 60);
            addRoom_dataGridView.Margin = new Padding(2);
            addRoom_dataGridView.Name = "addRoom_dataGridView";
            addRoom_dataGridView.RowHeadersWidth = 62;
            addRoom_dataGridView.RowTemplate.Height = 33;
            addRoom_dataGridView.Size = new Size(650, 204);
            addRoom_dataGridView.TabIndex = 1;
            // 
            // roomNumber_label
            // 
            roomNumber_label.AutoSize = true;
            roomNumber_label.Font = new Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point);
            roomNumber_label.ForeColor = Color.FromArgb(19, 15, 64);
            roomNumber_label.Location = new Point(680, 44);
            roomNumber_label.Margin = new Padding(2, 0, 2, 0);
            roomNumber_label.Name = "roomNumber_label";
            roomNumber_label.Size = new Size(108, 17);
            roomNumber_label.TabIndex = 2;
            roomNumber_label.Text = "Room Number";
            // 
            // roomType_label
            // 
            roomType_label.AutoSize = true;
            roomType_label.Font = new Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point);
            roomType_label.ForeColor = Color.FromArgb(19, 15, 64);
            roomType_label.Location = new Point(680, 94);
            roomType_label.Margin = new Padding(2, 0, 2, 0);
            roomType_label.Name = "roomType_label";
            roomType_label.Size = new Size(85, 17);
            roomType_label.TabIndex = 3;
            roomType_label.Text = "Room Type";
            // 
            // options_label
            // 
            options_label.AutoSize = true;
            options_label.Font = new Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point);
            options_label.ForeColor = Color.FromArgb(19, 15, 64);
            options_label.Location = new Point(680, 138);
            options_label.Margin = new Padding(2, 0, 2, 0);
            options_label.Name = "options_label";
            options_label.Size = new Size(61, 17);
            options_label.TabIndex = 4;
            options_label.Text = "Options";
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.Font = new Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point);
            price_label.ForeColor = Color.FromArgb(19, 15, 64);
            price_label.Location = new Point(680, 182);
            price_label.Margin = new Padding(2, 0, 2, 0);
            price_label.Name = "price_label";
            price_label.Size = new Size(41, 17);
            price_label.TabIndex = 5;
            price_label.Text = "Price";
            // 
            // roomNumber_textBox
            // 
            roomNumber_textBox.Location = new Point(680, 61);
            roomNumber_textBox.Margin = new Padding(2);
            roomNumber_textBox.MaxLength = 3;
            roomNumber_textBox.Name = "roomNumber_textBox";
            roomNumber_textBox.Size = new Size(184, 23);
            roomNumber_textBox.TabIndex = 6;
            roomNumber_textBox.TextChanged += roomNumber_textBox_TextChanged;
            roomNumber_textBox.KeyPress += roomNumber_textBox_KeyPress;
            // 
            // options_comboBox
            // 
            options_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            options_comboBox.FlatStyle = FlatStyle.Popup;
            options_comboBox.FormattingEnabled = true;
            options_comboBox.Items.AddRange(new object[] { "None", "Half board", "Full board", "All-inclusive" });
            options_comboBox.Location = new Point(680, 155);
            options_comboBox.Margin = new Padding(2);
            options_comboBox.Name = "options_comboBox";
            options_comboBox.Size = new Size(184, 23);
            options_comboBox.TabIndex = 8;
            options_comboBox.TextChanged += service_comboBox_TextChanged;
            // 
            // roomType_comboBox
            // 
            roomType_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomType_comboBox.FlatStyle = FlatStyle.Popup;
            roomType_comboBox.FormattingEnabled = true;
            roomType_comboBox.Items.AddRange(new object[] { "Standard", "Twin room", "Deluxe twin room", "Junior Suite", "Presidental Suite" });
            roomType_comboBox.Location = new Point(680, 109);
            roomType_comboBox.Margin = new Padding(2);
            roomType_comboBox.Name = "roomType_comboBox";
            roomType_comboBox.Size = new Size(184, 23);
            roomType_comboBox.TabIndex = 10;
            roomType_comboBox.TextChanged += roomType_TextChanged;
            // 
            // addRoom_button
            // 
            addRoom_button.FlatAppearance.BorderColor = Color.Black;
            addRoom_button.FlatAppearance.BorderSize = 2;
            addRoom_button.FlatStyle = FlatStyle.System;
            addRoom_button.ForeColor = Color.Black;
            addRoom_button.Location = new Point(729, 232);
            addRoom_button.Margin = new Padding(2);
            addRoom_button.Name = "addRoom_button";
            addRoom_button.Size = new Size(133, 32);
            addRoom_button.TabIndex = 11;
            addRoom_button.Text = "Add Room";
            addRoom_button.UseVisualStyleBackColor = true;
            addRoom_button.Click += addRoom_button_Click;
            // 
            // price_textBox
            // 
            price_textBox.Location = new Point(680, 197);
            price_textBox.Margin = new Padding(2);
            price_textBox.MaxLength = 6;
            price_textBox.Name = "price_textBox";
            price_textBox.Size = new Size(184, 23);
            price_textBox.TabIndex = 12;
            price_textBox.TextChanged += price_textBox_TextChanged;
            price_textBox.KeyPress += price_textBox_KeyPress;
            // 
            // database_error_label
            // 
            database_error_label.AutoSize = true;
            database_error_label.Font = new Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point);
            database_error_label.ForeColor = Color.Red;
            database_error_label.Location = new Point(325, 26);
            database_error_label.Name = "database_error_label";
            database_error_label.Size = new Size(0, 17);
            database_error_label.TabIndex = 13;
            // 
            // UC_AddRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(database_error_label);
            Controls.Add(price_textBox);
            Controls.Add(addRoom_button);
            Controls.Add(roomType_comboBox);
            Controls.Add(options_comboBox);
            Controls.Add(roomNumber_textBox);
            Controls.Add(price_label);
            Controls.Add(options_label);
            Controls.Add(roomType_label);
            Controls.Add(roomNumber_label);
            Controls.Add(addRoom_dataGridView);
            Controls.Add(heading_label);
            Margin = new Padding(2);
            Name = "UC_AddRooms";
            Size = new Size(956, 292);
            Load += UC_AddRooms_Load;
            ((System.ComponentModel.ISupportInitialize)addRoom_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading_label;
        private DataGridView addRoom_dataGridView;
        private Label roomNumber_label;
        private Label roomType_label;
        private Label options_label;
        private Label price_label;
        private TextBox roomNumber_textBox;
        private ComboBox options_comboBox;
        private ComboBox roomType_comboBox;
        private Button addRoom_button;
        private TextBox price_textBox;
        private Label database_error_label;
    }
}
