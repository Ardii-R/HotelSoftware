using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSoftware.User_Control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function functionClass = new function();


        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }



        public void setComboBox(string query, System.Windows.Forms.ComboBox comboBox)
        {
            SqlDataReader sqlDataReader = functionClass.getDataReader(query);
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    comboBox.Items.Add(sqlDataReader.GetString(i));
                }
            }
        }


        private void alloteRoom_button_Click(object sender, EventArgs e)
        {
            if (checkAlloteRoom())
            {

                string customerName = name_textBox.Text;
                string customerPhoneNumber = phoneNumber_textBox.Text;
                string customerNationality = nationality_textBox.Text;
                string customerGender = gender_comboBox.Text;
                string customerBirthday = birthday_dateTimePicker.Text;
                string customerID = id_textBox.Text;
                string customerAdress = address_textBox.Text;
                string customerCheckin = checkIn_dateTimePicker.Text;


                string insertCustomer = "INSERT INTO Customer (customer_name,phone,nationality,gender,birthday,personal_id,customer_address,checkin,roomid ) values ('" + customerName + "', '" + customerPhoneNumber + "', '" + customerNationality + "', '" + customerGender + "', '" + customerBirthday + "', '" + customerID + "', '" + customerAdress + "', '" + customerCheckin + "', " + roomID + ") update rooms set booked='YES' where roomNo = '" + roomNumber_comboBox.Text + "'";
                functionClass.setData(insertCustomer, $"The room {roomNumber_comboBox.Text} is assigned to {customerName} ");


                clearAll();
            }
        }


        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            name_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumber_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void phoneNumber_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nationality_textBox_TextChanged(object sender, EventArgs e)
        {
            nationality_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void nationality_textBox_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void gender_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {
            id_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void address_textBox_TextChanged(object sender, EventArgs e)
        {
            address_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void checkIn_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            checkIn_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void roomType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomType_label.ForeColor = Color.FromArgb(19, 15, 64);

            service_comboBox.SelectedIndex = -1;
            roomNumber_comboBox.Items.Clear();
            price_textBox.Clear();
        }

        int roomID;
        private void roomNumber_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomNumber_label.ForeColor = Color.FromArgb(19, 15, 64);

            try
            {
                string query = "SELECT price, roomid from rooms where roomNo = '" + roomNumber_comboBox.Text + "' ";
                DataSet ds = functionClass.getData(query);
                price_textBox.Text = ds.Tables[0].Rows[0][0].ToString();

                roomID = int.Parse(ds.Tables[0].Rows[0][1].ToString());

            }
            catch (Exception ex)
            {
                database_error_label.Text = "Database currently not available. It is not possible to register a customer";
                alloteRoom_button.Visible = false;
            }
        }

        private void service_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            service_comboBox.ForeColor = Color.FromArgb(19, 15, 64);

            roomNumber_comboBox.Items.Clear();
            price_textBox.Clear();

            try
            {
                string query = "SELECT roomNo from rooms where roomTyp ='" + roomType_comboBox.Text + "' and roomOptions ='" + service_comboBox.Text + "' and booked = 'NO' ";
                setComboBox(query, roomNumber_comboBox);
            }
            catch (Exception ex)
            {
                database_error_label.Text = "Database currently not available. It is not possible to register a customer";
                alloteRoom_button.Visible = false;
            }
        }

        private void price_textBox_TextChanged(object sender, EventArgs e)
        {
            price_label.ForeColor = Color.FromArgb(19, 15, 64);
        }

        private void price_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // allow decimal 
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void clearAll()
        {
            name_textBox.Clear();
            phoneNumber_textBox.Clear();
            nationality_textBox.Clear();
            gender_comboBox.SelectedIndex = -1;
            birthday_dateTimePicker.ResetText();
            id_textBox.Clear();
            address_textBox.Clear();
            checkIn_dateTimePicker.ResetText();
            roomType_comboBox.SelectedIndex = -1;
            service_comboBox.SelectedIndex = -1;
            roomNumber_comboBox.SelectedIndex = -1;
            price_textBox.Clear();
        }


        private Boolean checkAlloteRoom()
        {

            Boolean boolean = false;
            int caseSwitch = 0;

            if (name_textBox.TextLength < 1)
            {
                caseSwitch = 1;

            }
            else if (phoneNumber_textBox.TextLength < 11)
            {
                caseSwitch = 2;

            }
            else if (nationality_textBox.TextLength < 2)
            {
                caseSwitch = 3;
            }

            else if ((string.IsNullOrEmpty(gender_comboBox.Text)))
            {
                caseSwitch = 4;
            }

            else if ((DateTime.Today.Year - birthday_dateTimePicker.Value.Year) < 18)
            {
                caseSwitch = 5;
            }

            else if (id_textBox.TextLength < 5)
            {
                caseSwitch = 6;
            }

            else if (address_textBox.TextLength < 5)
            {
                caseSwitch = 7;
            }
            /*
            else if (checkIn_dateTimePicker)
            {
                caseSwitch = 8;
            }
            */
            /*
            else if (checkOut.)
            {
                caseSwitch = 9;
            }
            */
            else if ((string.IsNullOrEmpty(roomType_comboBox.Text)))
            {
                caseSwitch = 10;
            }

            else if ((string.IsNullOrEmpty(service_comboBox.Text)))
            {
                caseSwitch = 11;
            }

            else if ((string.IsNullOrEmpty(roomNumber_comboBox.Text)))
            {
                caseSwitch = 12;
            }

            else if (price_textBox.TextLength < 1)
            {
                caseSwitch = 13;
            }

            else
            {
                caseSwitch = 14;
            }


            switch (caseSwitch)
            {
                case 1:
                    name_label.ForeColor = Color.Red;
                    MessageBox.Show("The customer name is required for the registration, please insert the name of the customer.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 2:
                    phoneNumber_label.ForeColor = Color.Red;
                    MessageBox.Show("The phone number is required for the registration, please insert the phone number of the customer.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 3:
                    nationality_label.ForeColor = Color.Red;
                    MessageBox.Show("The nationality is required for the registration, please insert the nationality of the customer.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 4:
                    gender_label.ForeColor = Color.Red;
                    MessageBox.Show("The gender is required for the registration, please insert the gender of the customer.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 5:
                    birthday_label.ForeColor = Color.Red;
                    MessageBox.Show("The customer is not old enough to book a room!", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 6:
                    id_label.ForeColor = Color.Red;
                    MessageBox.Show("The is id required for the registration, please insert the id of the customer..", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 7:
                    address_label.ForeColor = Color.Red;
                    MessageBox.Show("The address is required for the registration, please insert the address of the customer.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 8:
                    checkIn_label.ForeColor = Color.Red;
                    MessageBox.Show("The checkin is required for the registration, please select a checkin date", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                /*
            case 9:
                break;
                */

                case 10:
                    roomType_label.ForeColor = Color.Red;
                    MessageBox.Show("The room type is required for the registration, please select a room type.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 11:
                    service_label.ForeColor = Color.Red;
                    MessageBox.Show("The service is required for the registration, please select a service.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 12:
                    roomNumber_label.ForeColor = Color.Red;
                    MessageBox.Show("The room number is required for the registration, please select a room number.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 13:
                    price_label.ForeColor = Color.Red;
                    MessageBox.Show("The price is required for the registration, please insert a price.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 14:
                    boolean = true;
                    break;
            }

            return boolean;
        }


    }
}

