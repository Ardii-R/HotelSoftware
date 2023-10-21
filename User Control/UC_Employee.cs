using System.Data;

namespace HotelSoftware.User_Control
{
    public partial class UC_Employee : UserControl
    {
        function functionClass = new function();

        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getNextFreeID();
        }


        private void empRegister_button_Click(object sender, EventArgs e)
        {
            if (checkEmployeeRegister())
            {
                string EmpName = empName_textBox.Text;
                string EmpMobileNumber = empMobileNum_textBox.Text;
                string EmpEmail = empEmail_textBox.Text;
                string EmpGender = empGender_comboBox.Text;
                string EmpUserName = empUserName_textBox.Text;
                string EmpPassword = empPassword_textBox.Text;

                string inerstEmp = "insert into employee (enployee_name, phone, gender, employee_mail, username,pwd) values ('" + EmpName + "', '" + EmpMobileNumber + "', '" + EmpGender + "','" + EmpEmail + "', '" + EmpUserName + "', '" + EmpPassword + "')";
                functionClass.setData(inerstEmp, "Employee successfully registered");

                clearAll();
                getNextFreeID();

            }
        }

        private void getNextFreeID()
        {
            try
            {
                string query = "select max(employee_id) from employee";
                DataSet ds = functionClass.getData(query);

                int freeID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                freeID_label.Text = (freeID + 1).ToString();

            }
            catch (Exception ex)
            {
                error_label.Visible = true;
                empRegister_button.Visible = false;
            }
        }

        private void empName_textBox_TextChanged(object sender, EventArgs e)
        {
            empName_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void empName_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void empMobileNum_textBox_TextChanged(object sender, EventArgs e)
        {
            empMobileNum_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void empMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void empEmail_textBox_TextChanged(object sender, EventArgs e)
        {
            EmpEmail_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void empGender_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            empGender_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void empUserName_textBox_TextChanged(object sender, EventArgs e)
        {
            empUserName_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void empPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            empPassword_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void clearAll()
        {
            empName_textBox.Clear();
            empMobileNum_textBox.Clear();
            empMobileNum_textBox.Clear();
            empGender_comboBox.SelectedIndex = -1;
            empUserName_textBox.Clear();
            empPassword_textBox.Clear();
        }

        private Boolean checkEmployeeRegister()
        {

            Boolean boolean = false;
            int caseSwitch = 0;

            if (empName_textBox.TextLength < 1)
            {
                caseSwitch = 1;

            }
            else if (empMobileNum_textBox.TextLength < 11)
            {
                caseSwitch = 2;

            }
            else if ((string.IsNullOrEmpty(empGender_comboBox.Text)))
            {
                caseSwitch = 3;
            }
            else if (empEmail_textBox.TextLength < 4)
            {
                caseSwitch = 4;
            }
            else if (empUserName_textBox.TextLength < 4)
            {
                caseSwitch = 5;
            }
            else if (empPassword_textBox.TextLength < 6)
            {
                caseSwitch = 6;
            }
            else
            {
                caseSwitch = 7;
            }


            switch (caseSwitch)
            {
                case 1:
                    empName_label.ForeColor = Color.Red;
                    MessageBox.Show("The employee name is required for the registration, please insert the name of the employee.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 2:
                    empMobileNum_label.ForeColor = Color.Red;
                    MessageBox.Show("The phone number is required for the registration, please insert the phone number of the employee.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 3:
                    empGender_label.ForeColor = Color.Red;
                    MessageBox.Show("The gender is required for the registration, please insert the gender of the employee.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 4:
                    EmpEmail_label.ForeColor = Color.Red;
                    MessageBox.Show("The E-Mail is required for the registration, please insert the E-Mail of the employee.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 5:
                    empUserName_label.ForeColor = Color.Red;
                    MessageBox.Show("The username is required for the registration, please insert a username for the employee.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 6:
                    empPassword_label.ForeColor = Color.Red;
                    MessageBox.Show("password textbox cannot be empty.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 7:
                    boolean = true;
                    break;
            }

            return boolean;
        }

        private void tabEmployee_selectedIndex(object sender, EventArgs e)
        {
            if (Emp_tabControll.SelectedIndex == 1)
            {
                SetEmployeeData(empDetail_DataGridView);

            }
            else if (Emp_tabControll.SelectedIndex == 2)
            {
                SetEmployeeData(empDelete_DataGridView);

            }
        }


        private void SetEmployeeData(DataGridView dataGridView)
        {
            string showEmpQuery = "Select * FROM employee";
            DataSet dataSet = new DataSet();
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void delEmployee_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(delID_textBox.Text) == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the employee: ", "Confirmation!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string deleteEmpQuery = "delete from employee where employee_id = " + delID_textBox.Text + "";
                        functionClass.setData(deleteEmpQuery, "Delete successfully");
                        tabEmployee_selectedIndex(this, null);

                    }
                }
            }
            catch
            {
            }
        }

        private void empDeleteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
