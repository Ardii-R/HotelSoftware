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
            label1 = new Label();
            SuspendLayout();
            // 
            // heading_label
            // 
            heading_label.AutoSize = true;
            heading_label.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point);
            heading_label.Location = new Point(15, 14);
            heading_label.Margin = new Padding(2);
            heading_label.Name = "heading_label";
            heading_label.Size = new Size(198, 30);
            heading_label.TabIndex = 1;
            heading_label.Text = "Add new Room";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 102);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 2;
            label1.Text = "to be implemented ...";
            // 
            // UC_Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(heading_label);
            Name = "UC_Checkout";
            Size = new Size(956, 292);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading_label;
        private Label label1;
    }
}
