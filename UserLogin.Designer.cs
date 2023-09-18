namespace HotelSoftware
{
    partial class UserLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            exitButton = new Panel();
            loginLogo_pictureBox = new PictureBox();
            button2 = new Button();
            errorLabel = new Label();
            loginButton = new Button();
            pictureBox1 = new PictureBox();
            password_textBox = new TextBox();
            username_pictureBox = new PictureBox();
            username_textBox = new TextBox();
            label1 = new Label();
            exitButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginLogo_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)username_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.White;
            exitButton.Controls.Add(loginLogo_pictureBox);
            exitButton.Controls.Add(button2);
            exitButton.Controls.Add(errorLabel);
            exitButton.Controls.Add(loginButton);
            exitButton.Controls.Add(pictureBox1);
            exitButton.Controls.Add(password_textBox);
            exitButton.Controls.Add(username_pictureBox);
            exitButton.Controls.Add(username_textBox);
            exitButton.Controls.Add(label1);
            exitButton.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(215, 117);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(728, 374);
            exitButton.TabIndex = 0;
            // 
            // loginLogo_pictureBox
            // 
            loginLogo_pictureBox.Image = (Image)resources.GetObject("loginLogo_pictureBox.Image");
            loginLogo_pictureBox.Location = new Point(428, 97);
            loginLogo_pictureBox.Name = "loginLogo_pictureBox";
            loginLogo_pictureBox.Size = new Size(265, 188);
            loginLogo_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loginLogo_pictureBox.TabIndex = 2;
            loginLogo_pictureBox.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(663, 3);
            button2.Name = "button2";
            button2.Size = new Size(62, 44);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(107, 329);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(225, 20);
            errorLabel.TabIndex = 8;
            errorLabel.Text = "Wrong Username or Password";
            errorLabel.Visible = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(0, 192, 0);
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(117, 267);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(205, 48);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // password_textBox
            // 
            password_textBox.BackColor = Color.FromArgb(224, 224, 224);
            password_textBox.Location = new Point(161, 197);
            password_textBox.Name = "password_textBox";
            password_textBox.PlaceholderText = "Password";
            password_textBox.Size = new Size(202, 39);
            password_textBox.TabIndex = 5;
            password_textBox.TextAlign = HorizontalAlignment.Center;
            password_textBox.UseSystemPasswordChar = true;
            password_textBox.KeyDown += password_textBox_KeyDown;
            // 
            // username_pictureBox
            // 
            username_pictureBox.BackColor = Color.Transparent;
            username_pictureBox.Image = (Image)resources.GetObject("username_pictureBox.Image");
            username_pictureBox.Location = new Point(79, 87);
            username_pictureBox.Name = "username_pictureBox";
            username_pictureBox.Size = new Size(63, 62);
            username_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            username_pictureBox.TabIndex = 4;
            username_pictureBox.TabStop = false;
            // 
            // username_textBox
            // 
            username_textBox.BackColor = Color.FromArgb(224, 224, 224);
            username_textBox.Location = new Point(161, 97);
            username_textBox.Name = "username_textBox";
            username_textBox.PlaceholderText = "Username";
            username_textBox.Size = new Size(202, 39);
            username_textBox.TabIndex = 3;
            username_textBox.TextAlign = HorizontalAlignment.Center;
            username_textBox.KeyDown += username_textBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(273, 22);
            label1.Name = "label1";
            label1.Size = new Size(162, 36);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1283, 711);
            Controls.Add(exitButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            exitButton.ResumeLayout(false);
            exitButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginLogo_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)username_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel exitButton;
        private Label label1;
        private PictureBox loginLogo_pictureBox;
        private TextBox username_textBox;
        private PictureBox username_pictureBox;
        private PictureBox pictureBox1;
        private TextBox password_textBox;
        private Button loginButton;
        private Label errorLabel;
        private Button button2;
    }
}