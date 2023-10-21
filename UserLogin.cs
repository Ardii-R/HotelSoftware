using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace HotelSoftware
{
    public partial class UserLogin : Form
    {
        function functionClass = new function();

        public UserLogin()
        {
            InitializeComponent();
            //checkDatabaseConnection();
        }

        private void checkDatabaseConnection()
        {
            try
            {
                SqlConnection con = functionClass.getConnection();
            }
            catch (Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            /*
            if ((username_textBox.Text == "User") && (password_textBox.Text == "pwd"))
            {
                //TODO 
                errorLabel.Visible = false;
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                errorLabel.Visible = true;
                password_textBox.Clear();
            }
            */

            string query = "Select username, pwd from employee where username = '"+username_textBox.Text+"' and pwd = '"+password_textBox.Text+"'";
            DataSet ds = functionClass.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                errorLabel.Visible = true;
                password_textBox.Clear();
            }
            
        }

        private void username_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                password_textBox.Select();
            }
        }
        private void password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(this, new EventArgs());
            }
        }

    }
}