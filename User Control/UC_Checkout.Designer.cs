namespace HotelSoftware.User_Control
{
    partial class UC_Checkout
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
            namesearch_textBox = new TextBox();
            name_label = new Label();
            checkout_dataGridView = new DataGridView();
            nameCheckout_textBox = new TextBox();
            nameCheckout_label = new Label();
            roomNumber_label = new Label();
            Checkout_label = new Label();
            Checkout_dateTimePicker = new DateTimePicker();
            roomNumbertextBox = new TextBox();
            checkout_button = new Button();
            error_label = new Label();
            ((System.ComponentModel.ISupportInitialize)checkout_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // heading_label
            // 
            heading_label.AutoSize = true;
            heading_label.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point);
            heading_label.Location = new Point(15, 14);
            heading_label.Margin = new Padding(2);
            heading_label.Name = "heading_label";
            heading_label.Size = new Size(131, 30);
            heading_label.TabIndex = 1;
            heading_label.Text = "Checkout";
            // 
            // namesearch_textBox
            // 
            namesearch_textBox.AllowDrop = true;
            namesearch_textBox.Location = new Point(371, 42);
            namesearch_textBox.Margin = new Padding(2);
            namesearch_textBox.MaxLength = 35;
            namesearch_textBox.Name = "namesearch_textBox";
            namesearch_textBox.PlaceholderText = "Enter full name";
            namesearch_textBox.Size = new Size(193, 23);
            namesearch_textBox.TabIndex = 9;
            namesearch_textBox.TextChanged += name_textBox_TextChanged;
            // 
            // name_label
            // 
            name_label.AllowDrop = true;
            name_label.AutoSize = true;
            name_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            name_label.ForeColor = Color.FromArgb(19, 15, 64);
            name_label.Location = new Point(371, 23);
            name_label.Margin = new Padding(2, 0, 2, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(13, 19);
            name_label.TabIndex = 8;
            name_label.Text = " ";
            // 
            // checkout_dataGridView
            // 
            checkout_dataGridView.BackgroundColor = Color.White;
            checkout_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            checkout_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            checkout_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            checkout_dataGridView.Location = new Point(15, 70);
            checkout_dataGridView.Name = "checkout_dataGridView";
            checkout_dataGridView.RowTemplate.Height = 25;
            checkout_dataGridView.Size = new Size(922, 157);
            checkout_dataGridView.TabIndex = 10;
            checkout_dataGridView.CellContentClick += checkout_dataGridView_CellContentClick;
            // 
            // nameCheckout_textBox
            // 
            nameCheckout_textBox.AllowDrop = true;
            nameCheckout_textBox.BackColor = Color.White;
            nameCheckout_textBox.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            nameCheckout_textBox.Location = new Point(15, 249);
            nameCheckout_textBox.Margin = new Padding(2);
            nameCheckout_textBox.MaxLength = 35;
            nameCheckout_textBox.Name = "nameCheckout_textBox";
            nameCheckout_textBox.PlaceholderText = "Customer name";
            nameCheckout_textBox.ReadOnly = true;
            nameCheckout_textBox.Size = new Size(165, 23);
            nameCheckout_textBox.TabIndex = 12;
            // 
            // nameCheckout_label
            // 
            nameCheckout_label.AllowDrop = true;
            nameCheckout_label.AutoSize = true;
            nameCheckout_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            nameCheckout_label.ForeColor = Color.FromArgb(19, 15, 64);
            nameCheckout_label.Location = new Point(15, 230);
            nameCheckout_label.Margin = new Padding(2, 0, 2, 0);
            nameCheckout_label.Name = "nameCheckout_label";
            nameCheckout_label.Size = new Size(58, 19);
            nameCheckout_label.TabIndex = 11;
            nameCheckout_label.Text = "Name";
            // 
            // roomNumber_label
            // 
            roomNumber_label.AllowDrop = true;
            roomNumber_label.AutoSize = true;
            roomNumber_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            roomNumber_label.ForeColor = Color.FromArgb(19, 15, 64);
            roomNumber_label.Location = new Point(301, 230);
            roomNumber_label.Margin = new Padding(2, 0, 2, 0);
            roomNumber_label.Name = "roomNumber_label";
            roomNumber_label.Size = new Size(120, 19);
            roomNumber_label.TabIndex = 13;
            roomNumber_label.Text = "Room number";
            // 
            // Checkout_label
            // 
            Checkout_label.AllowDrop = true;
            Checkout_label.AutoSize = true;
            Checkout_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Checkout_label.ForeColor = Color.FromArgb(19, 15, 64);
            Checkout_label.Location = new Point(562, 230);
            Checkout_label.Margin = new Padding(2, 0, 2, 0);
            Checkout_label.Name = "Checkout_label";
            Checkout_label.Size = new Size(87, 19);
            Checkout_label.TabIndex = 15;
            Checkout_label.Text = "Checkout";
            // 
            // Checkout_dateTimePicker
            // 
            Checkout_dateTimePicker.Format = DateTimePickerFormat.Short;
            Checkout_dateTimePicker.Location = new Point(562, 255);
            Checkout_dateTimePicker.Name = "Checkout_dateTimePicker";
            Checkout_dateTimePicker.Size = new Size(165, 23);
            Checkout_dateTimePicker.TabIndex = 18;
            // 
            // roomNumbertextBox
            // 
            roomNumbertextBox.AllowDrop = true;
            roomNumbertextBox.BackColor = Color.White;
            roomNumbertextBox.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            roomNumbertextBox.Location = new Point(301, 255);
            roomNumbertextBox.Margin = new Padding(2);
            roomNumbertextBox.MaxLength = 35;
            roomNumbertextBox.Name = "roomNumbertextBox";
            roomNumbertextBox.PlaceholderText = "Room number";
            roomNumbertextBox.ReadOnly = true;
            roomNumbertextBox.Size = new Size(165, 23);
            roomNumbertextBox.TabIndex = 19;
            // 
            // checkout_button
            // 
            checkout_button.BackColor = Color.FromArgb(19, 15, 64);
            checkout_button.FlatAppearance.BorderColor = Color.White;
            checkout_button.FlatAppearance.BorderSize = 2;
            checkout_button.FlatStyle = FlatStyle.Popup;
            checkout_button.ForeColor = Color.White;
            checkout_button.Location = new Point(804, 249);
            checkout_button.Margin = new Padding(2);
            checkout_button.Name = "checkout_button";
            checkout_button.Size = new Size(133, 32);
            checkout_button.TabIndex = 34;
            checkout_button.Text = "Checkout";
            checkout_button.UseVisualStyleBackColor = false;
            checkout_button.Click += checkout_button_Click;
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(531, 14);
            error_label.Name = "error_label";
            error_label.Size = new Size(394, 15);
            error_label.TabIndex = 35;
            error_label.Text = "Database currently not available. It is not possible to checkout a customer";
            error_label.Visible = false;
            // 
            // UC_Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(error_label);
            Controls.Add(checkout_button);
            Controls.Add(roomNumbertextBox);
            Controls.Add(Checkout_dateTimePicker);
            Controls.Add(Checkout_label);
            Controls.Add(roomNumber_label);
            Controls.Add(nameCheckout_textBox);
            Controls.Add(nameCheckout_label);
            Controls.Add(checkout_dataGridView);
            Controls.Add(namesearch_textBox);
            Controls.Add(name_label);
            Controls.Add(heading_label);
            Name = "UC_Checkout";
            Size = new Size(956, 292);
            Load += UC_Checkout_Load;
            ((System.ComponentModel.ISupportInitialize)checkout_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading_label;
        private TextBox namesearch_textBox;
        private Label name_label;
        private DataGridView checkout_dataGridView;
        private TextBox nameCheckout_textBox;
        private Label nameCheckout_label;
        private Label roomNumber_label;
        private Label Checkout_label;
        private DateTimePicker Checkout_dateTimePicker;
        private TextBox roomNumbertextBox;
        private Button checkout_button;
        private Label error_label;
    }
}
