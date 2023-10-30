namespace HotelSoftware.User_Control
{
    partial class UC_CustomerDetails
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
            customerDetail_dataGridView = new DataGridView();
            error_label = new Label();
            search_comboBox = new ComboBox();
            search_label = new Label();
            ((System.ComponentModel.ISupportInitialize)customerDetail_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // heading_label
            // 
            heading_label.AutoSize = true;
            heading_label.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point);
            heading_label.Location = new Point(15, 14);
            heading_label.Margin = new Padding(2);
            heading_label.Name = "heading_label";
            heading_label.Size = new Size(204, 30);
            heading_label.TabIndex = 2;
            heading_label.Text = "Customer detail";
            // 
            // customerDetail_dataGridView
            // 
            customerDetail_dataGridView.BackgroundColor = Color.White;
            customerDetail_dataGridView.BorderStyle = BorderStyle.Fixed3D;
            customerDetail_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDetail_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            customerDetail_dataGridView.Location = new Point(17, 114);
            customerDetail_dataGridView.Name = "customerDetail_dataGridView";
            customerDetail_dataGridView.RowTemplate.Height = 25;
            customerDetail_dataGridView.Size = new Size(926, 161);
            customerDetail_dataGridView.TabIndex = 11;
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(531, 14);
            error_label.Name = "error_label";
            error_label.Size = new Size(322, 15);
            error_label.TabIndex = 36;
            error_label.Text = "Database currently not available. Customer details restricted";
            error_label.Visible = false;
            // 
            // search_comboBox
            // 
            search_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            search_comboBox.FlatStyle = FlatStyle.Popup;
            search_comboBox.FormattingEnabled = true;
            search_comboBox.Items.AddRange(new object[] { "All customer details", "Checkout customer", "Non-checkout customer" });
            search_comboBox.Location = new Point(378, 77);
            search_comboBox.Margin = new Padding(2);
            search_comboBox.Name = "search_comboBox";
            search_comboBox.Size = new Size(193, 23);
            search_comboBox.TabIndex = 37;
            search_comboBox.SelectedIndexChanged += search_comboBox_SelectedIndexChanged;
            // 
            // search_label
            // 
            search_label.AllowDrop = true;
            search_label.AutoSize = true;
            search_label.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            search_label.ForeColor = Color.FromArgb(19, 15, 64);
            search_label.Location = new Point(416, 45);
            search_label.Margin = new Padding(2, 0, 2, 0);
            search_label.Name = "search_label";
            search_label.Size = new Size(163, 19);
            search_label.TabIndex = 38;
            search_label.Text = "Search customer by";
            // 
            // UC_CustomerDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(search_label);
            Controls.Add(search_comboBox);
            Controls.Add(error_label);
            Controls.Add(customerDetail_dataGridView);
            Controls.Add(heading_label);
            Name = "UC_CustomerDetails";
            Size = new Size(956, 292);
            ((System.ComponentModel.ISupportInitialize)customerDetail_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading_label;
        private DataGridView customerDetail_dataGridView;
        private Label error_label;
        private ComboBox search_comboBox;
        private Label search_label;
    }
}
