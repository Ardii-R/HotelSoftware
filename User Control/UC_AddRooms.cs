using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace HotelSoftware.User_Control
{
    public partial class UC_AddRooms : UserControl
    {

        function functionClass = new function();
        private readonly string query = "select * from rooms";
        private string insert;

        private Dictionary<string, int> roomPrice = new Dictionary<string, int>();
        private Dictionary<string, int> optionPrice = new Dictionary<string, int>();


        public UC_AddRooms()
        {
            InitializeComponent();
            InitializePrices();
        }

        private void InitializePrices()
        {

            roomPrice.Add("Standard", 50);
            roomPrice.Add("Twin room", 70);
            roomPrice.Add("Deluxe twin room", 100);
            roomPrice.Add("Junior Suite", 170);
            roomPrice.Add("Presidental Suite", 250);

            optionPrice.Add("None", 0);
            optionPrice.Add("Half board", 35);
            optionPrice.Add("Full board", 50);
            optionPrice.Add("All-inclusive", 80);
        }



        private void addRoom_button_Click(object sender, EventArgs e)
        {
            if (controllAddRoom() && price_textBox.Text.Length < 1)
            {
                int caclPrice = calculatePrice();

                DialogResult dialogResult = MessageBox.Show($"The price of the new room will be {caclPrice} Euros", "Price", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // extract data from textboxes 
                    string roomNumber = roomNumber_textBox.Text;
                    string roomType = roomType_comboBox.Text;
                    string roomService = options_comboBox.Text;
                    int price = int.Parse(price_textBox.Text);


                    // insert data into database
                    insert = "INSERT INTO rooms (roomNo,roomTyp,roomService,price) values ('" + roomNumber + ",'" + roomType + "','" + roomService + "'," + price + " )";
                    functionClass.setData(query, $"Added new room: {roomType} with price of {price} Euro");

                    UC_AddRooms_Load(this, null);
                    clearPage();

                }
                else if (dialogResult == DialogResult.No)
                {
                    price_textBox.Clear();
                    price_label.ForeColor = Color.Red;
                }

            }
            else if (price_textBox.Text.Length > 1 && controllAddRoom())
            {
                // extract data from textboxes 
                string roomNumber = roomNumber_textBox.Text;
                string roomType = roomType_comboBox.Text;
                string roomOptions = options_comboBox.Text;
                int price = int.Parse(price_textBox.Text);


                // insert data into database
                insert = "INSERT INTO rooms (roomNo,roomTyp,roomOptions,price) values ('" + roomNumber + "','" + roomType + "','" + roomOptions + "'," + price + ")";
                functionClass.setData(query, $"Added new room: {roomType} with price of {price} Euro");

                UC_AddRooms_Load(this, null);
                clearPage();
            }
        }


        private void roomNumber_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void roomNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            roomNumber_label.ForeColor = Color.FromArgb(19, 15, 64);
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

        private void roomType_TextChanged(object sender, EventArgs e)
        {
            roomType_label.ForeColor = Color.FromArgb(19, 15, 64);
        }


        private void service_comboBox_TextChanged(object sender, EventArgs e)
        {
            options_label.ForeColor = Color.FromArgb(19, 15, 64);
        }


        private void price_textBox_TextChanged(object sender, EventArgs e)
        {
            price_label.ForeColor = Color.FromArgb(19, 15, 64);
        }



        private Boolean controllAddRoom()
        {


            Boolean boolean = false;
            int caseSwitch = 0;

            if (roomNumber_textBox.TextLength < 1)
            {
                caseSwitch = 1;

            }
            else if (string.IsNullOrEmpty(roomType_comboBox.Text))
            {
                caseSwitch = 2;

            }
            else if (string.IsNullOrEmpty(options_comboBox.Text))
            {
                caseSwitch = 3;
            }
            /*
            else if (price_textBox.TextLength < 1)
            {
                caseSwitch = 4;
            }
            */
            else
            {
                caseSwitch = 5;
            }


            switch (caseSwitch)
            {
                case 1:
                    roomNumber_label.ForeColor = Color.Red;
                    MessageBox.Show("The room number is required to add a new room, please insert a valid room number.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 2:
                    roomType_label.ForeColor = Color.Red;
                    MessageBox.Show("The room type is required to add a new room, please select a room type.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 3:
                    options_label.ForeColor = Color.Red;
                    MessageBox.Show("The room option is required to add a new room, please select a room service.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 4:
                    price_label.ForeColor = Color.Red;
                    MessageBox.Show("The price is required to add a new room, please insert a valid price for the room.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 5:
                    boolean = true;
                    break;
            }

            return boolean;
        }

        private void UC_AddRooms_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = functionClass.getData(query);
                addRoom_dataGridView.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                database_error_label.Text = "Database currently not available. It is not possible to add a new room";
                addRoom_button.Visible = false;
            }

        }

        /*
        private void UC_AddRooms_Leave(object sender, EventArgs e)
        {
            clearPage();
        }

        private void UC_AddRooms_Enter(object sender, EventArgs e)
        {
            UC_AddRooms_Load(this, null);
        }

        */

        private int calculatePrice()
        {
            int price = 0;
            string roomType = roomType_comboBox.Text;
            string roomOption = options_comboBox.Text;

            price += roomPrice[roomType];
            price += optionPrice[roomOption];

            price_textBox.Text = price.ToString();

            return price;
        }

        public void clearPage()
        {
            roomNumber_textBox.Clear();
            roomType_comboBox.SelectedIndex = -1;
            options_comboBox.SelectedIndex = -1;
            price_textBox.Clear();
        }
    }
}
