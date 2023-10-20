namespace HotelSoftware
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            closing_button = new Button();
            panel1 = new Panel();
            underline_panel = new Panel();
            employee_radioButton = new RadioButton();
            CustomerDetails_radioButton = new RadioButton();
            CheckOut_radioButton = new RadioButton();
            customerRegistration_radioButton = new RadioButton();
            addRooms_RaidioButton = new RadioButton();
            uc_dashboardPanel = new Panel();
            minimize_button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // closing_button
            // 
            closing_button.BackColor = Color.FromArgb(19, 15, 64);
            closing_button.BackgroundImageLayout = ImageLayout.Stretch;
            closing_button.FlatAppearance.BorderColor = Color.FromArgb(19, 15, 64);
            closing_button.FlatAppearance.BorderSize = 0;
            closing_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 15, 64);
            closing_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 15, 64);
            closing_button.FlatStyle = FlatStyle.Flat;
            closing_button.Image = (Image)resources.GetObject("closing_button.Image");
            closing_button.Location = new Point(927, 7);
            closing_button.Margin = new Padding(2);
            closing_button.Name = "closing_button";
            closing_button.Size = new Size(45, 40);
            closing_button.TabIndex = 10;
            closing_button.UseVisualStyleBackColor = false;
            closing_button.Click += closing_button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 15, 64);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(underline_panel);
            panel1.Controls.Add(employee_radioButton);
            panel1.Controls.Add(CustomerDetails_radioButton);
            panel1.Controls.Add(CheckOut_radioButton);
            panel1.Controls.Add(customerRegistration_radioButton);
            panel1.Controls.Add(addRooms_RaidioButton);
            panel1.Location = new Point(8, 7);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 80);
            panel1.TabIndex = 11;
            // 
            // underline_panel
            // 
            underline_panel.BackColor = Color.White;
            underline_panel.Location = new Point(10, 68);
            underline_panel.Margin = new Padding(2);
            underline_panel.Name = "underline_panel";
            underline_panel.Size = new Size(146, 3);
            underline_panel.TabIndex = 0;
            // 
            // employee_radioButton
            // 
            employee_radioButton.Appearance = Appearance.Button;
            employee_radioButton.BackColor = Color.FromArgb(19, 15, 64);
            employee_radioButton.FlatAppearance.BorderColor = Color.FromArgb(19, 15, 64);
            employee_radioButton.FlatStyle = FlatStyle.Flat;
            employee_radioButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            employee_radioButton.ForeColor = Color.White;
            employee_radioButton.Image = (Image)resources.GetObject("employee_radioButton.Image");
            employee_radioButton.ImageAlign = ContentAlignment.MiddleRight;
            employee_radioButton.Location = new Point(749, 10);
            employee_radioButton.Margin = new Padding(2);
            employee_radioButton.Name = "employee_radioButton";
            employee_radioButton.Size = new Size(150, 56);
            employee_radioButton.TabIndex = 4;
            employee_radioButton.Text = "Employee";
            employee_radioButton.TextAlign = ContentAlignment.MiddleCenter;
            employee_radioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            employee_radioButton.UseVisualStyleBackColor = false;
            employee_radioButton.CheckedChanged += employee_radioButton_CheckedChanged;
            employee_radioButton.MouseLeave += employee_radioButton_MouseLeave;
            employee_radioButton.MouseHover += employee_radioButton_MouseHover;
            // 
            // CustomerDetails_radioButton
            // 
            CustomerDetails_radioButton.Appearance = Appearance.Button;
            CustomerDetails_radioButton.BackColor = Color.FromArgb(19, 15, 64);
            CustomerDetails_radioButton.FlatAppearance.BorderColor = Color.FromArgb(19, 15, 64);
            CustomerDetails_radioButton.FlatStyle = FlatStyle.Flat;
            CustomerDetails_radioButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerDetails_radioButton.ForeColor = Color.White;
            CustomerDetails_radioButton.Image = (Image)resources.GetObject("CustomerDetails_radioButton.Image");
            CustomerDetails_radioButton.ImageAlign = ContentAlignment.MiddleRight;
            CustomerDetails_radioButton.Location = new Point(571, 10);
            CustomerDetails_radioButton.Margin = new Padding(2);
            CustomerDetails_radioButton.Name = "CustomerDetails_radioButton";
            CustomerDetails_radioButton.Size = new Size(150, 56);
            CustomerDetails_radioButton.TabIndex = 3;
            CustomerDetails_radioButton.Text = "Customer \r\nDetails";
            CustomerDetails_radioButton.TextAlign = ContentAlignment.MiddleCenter;
            CustomerDetails_radioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CustomerDetails_radioButton.UseVisualStyleBackColor = false;
            CustomerDetails_radioButton.CheckedChanged += CustomerDetails_radioButton_CheckedChanged;
            CustomerDetails_radioButton.MouseLeave += CustomerDetails_radioButton_MouseLeave;
            CustomerDetails_radioButton.MouseHover += CustomerDetails_radioButton_MouseHover;
            // 
            // CheckOut_radioButton
            // 
            CheckOut_radioButton.Appearance = Appearance.Button;
            CheckOut_radioButton.BackColor = Color.FromArgb(19, 15, 64);
            CheckOut_radioButton.FlatAppearance.BorderColor = Color.FromArgb(19, 15, 64);
            CheckOut_radioButton.FlatStyle = FlatStyle.Flat;
            CheckOut_radioButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckOut_radioButton.ForeColor = Color.White;
            CheckOut_radioButton.Image = (Image)resources.GetObject("CheckOut_radioButton.Image");
            CheckOut_radioButton.ImageAlign = ContentAlignment.MiddleRight;
            CheckOut_radioButton.Location = new Point(387, 10);
            CheckOut_radioButton.Margin = new Padding(2);
            CheckOut_radioButton.Name = "CheckOut_radioButton";
            CheckOut_radioButton.Size = new Size(150, 56);
            CheckOut_radioButton.TabIndex = 2;
            CheckOut_radioButton.Text = "Check Out";
            CheckOut_radioButton.TextAlign = ContentAlignment.MiddleCenter;
            CheckOut_radioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CheckOut_radioButton.UseVisualStyleBackColor = false;
            CheckOut_radioButton.CheckedChanged += CheckOut_radioButton_CheckedChanged;
            CheckOut_radioButton.MouseLeave += CheckOut_radioButton_MouseLeave;
            CheckOut_radioButton.MouseHover += CheckOut_radioButton_MouseHover;
            // 
            // customerRegistration_radioButton
            // 
            customerRegistration_radioButton.Appearance = Appearance.Button;
            customerRegistration_radioButton.BackColor = Color.FromArgb(19, 15, 64);
            customerRegistration_radioButton.FlatAppearance.BorderColor = Color.FromArgb(19, 15, 64);
            customerRegistration_radioButton.FlatStyle = FlatStyle.Flat;
            customerRegistration_radioButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerRegistration_radioButton.ForeColor = Color.White;
            customerRegistration_radioButton.Image = (Image)resources.GetObject("customerRegistration_radioButton.Image");
            customerRegistration_radioButton.ImageAlign = ContentAlignment.MiddleRight;
            customerRegistration_radioButton.Location = new Point(209, 10);
            customerRegistration_radioButton.Margin = new Padding(2);
            customerRegistration_radioButton.Name = "customerRegistration_radioButton";
            customerRegistration_radioButton.Size = new Size(150, 56);
            customerRegistration_radioButton.TabIndex = 1;
            customerRegistration_radioButton.Text = "Customer \r\nRegistration\r\n";
            customerRegistration_radioButton.TextAlign = ContentAlignment.MiddleCenter;
            customerRegistration_radioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            customerRegistration_radioButton.UseVisualStyleBackColor = false;
            customerRegistration_radioButton.CheckedChanged += customerRegistration_radioButton_CheckedChanged;
            customerRegistration_radioButton.MouseLeave += customerRegistration_radioButton_MouseLeave;
            customerRegistration_radioButton.MouseHover += customerRegistration_radioButton_MouseHover;
            // 
            // addRooms_RaidioButton
            // 
            addRooms_RaidioButton.Appearance = Appearance.Button;
            addRooms_RaidioButton.BackColor = Color.White;
            addRooms_RaidioButton.Checked = true;
            addRooms_RaidioButton.FlatAppearance.BorderColor = Color.FromArgb(19, 15, 64);
            addRooms_RaidioButton.FlatStyle = FlatStyle.Flat;
            addRooms_RaidioButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addRooms_RaidioButton.ForeColor = Color.Black;
            addRooms_RaidioButton.Image = (Image)resources.GetObject("addRooms_RaidioButton.Image");
            addRooms_RaidioButton.ImageAlign = ContentAlignment.MiddleRight;
            addRooms_RaidioButton.Location = new Point(10, 10);
            addRooms_RaidioButton.Margin = new Padding(2);
            addRooms_RaidioButton.Name = "addRooms_RaidioButton";
            addRooms_RaidioButton.Size = new Size(150, 56);
            addRooms_RaidioButton.TabIndex = 0;
            addRooms_RaidioButton.TabStop = true;
            addRooms_RaidioButton.Text = "Add Rooms\r\n";
            addRooms_RaidioButton.TextAlign = ContentAlignment.MiddleCenter;
            addRooms_RaidioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addRooms_RaidioButton.UseVisualStyleBackColor = false;
            addRooms_RaidioButton.CheckedChanged += addRooms_RaidioButton_CheckedChanged;
            addRooms_RaidioButton.MouseLeave += addRooms_RaidioButton_MouseLeave;
            addRooms_RaidioButton.MouseHover += addRooms_RaidioButton_MouseHover;
            // 
            // uc_dashboardPanel
            // 
            uc_dashboardPanel.BackColor = Color.FromArgb(19, 15, 64);
            uc_dashboardPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uc_dashboardPanel.Location = new Point(8, 103);
            uc_dashboardPanel.Margin = new Padding(2);
            uc_dashboardPanel.Name = "uc_dashboardPanel";
            uc_dashboardPanel.Size = new Size(956, 292);
            uc_dashboardPanel.TabIndex = 12;
            // 
            // minimize_button
            // 
            minimize_button.BackColor = Color.FromArgb(19, 15, 64);
            minimize_button.BackgroundImageLayout = ImageLayout.Stretch;
            minimize_button.FlatAppearance.BorderColor = Color.FromArgb(19, 15, 64);
            minimize_button.FlatAppearance.BorderSize = 0;
            minimize_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 15, 64);
            minimize_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 15, 64);
            minimize_button.FlatStyle = FlatStyle.Flat;
            minimize_button.ForeColor = Color.FromArgb(19, 15, 64);
            minimize_button.Image = (Image)resources.GetObject("minimize_button.Image");
            minimize_button.Location = new Point(927, 51);
            minimize_button.Margin = new Padding(2);
            minimize_button.Name = "minimize_button";
            minimize_button.Size = new Size(45, 45);
            minimize_button.TabIndex = 0;
            minimize_button.UseVisualStyleBackColor = false;
            minimize_button.Click += minimize_button_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 15, 64);
            ClientSize = new Size(973, 417);
            Controls.Add(minimize_button);
            Controls.Add(uc_dashboardPanel);
            Controls.Add(panel1);
            Controls.Add(closing_button);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button closing_button;
        private Panel panel1;
        private Panel uc_dashboardPanel;
        private Button minimize_button;
        private RadioButton addRooms_RaidioButton;
        private RadioButton customerRegistration_radioButton;
        private RadioButton CustomerDetails_radioButton;
        private RadioButton CheckOut_radioButton;
        private RadioButton employee_radioButton;
        private Panel underline_panel;
    }
}