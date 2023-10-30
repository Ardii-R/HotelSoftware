using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace HotelSoftware.User_Control
{
    public partial class UC_Checkout : UserControl
    {

        function functionClass = new function();

        public UC_Checkout()

        {
            InitializeComponent();
        }

        private void UC_Checkout_Load(object sender, EventArgs e)
        {
            try
            {
                string loadQuery = "Select Customer.customer_id, Customer.customer_name, Customer.phone, Customer.nationality, Customer.gender, Customer.birthday, Customer.personal_id, Customer.customer_address, Customer.checkin, rooms.roomNo, rooms.roomTyp, rooms.roomOptions, rooms.price from Customer inner join rooms on Customer.roomid = rooms.roomid WHERE checkout = 'NO'";
                DataSet dataSet = functionClass.getData(loadQuery);
                checkout_dataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                error_label.Visible = true;
                checkout_button.Visible = false;
            }

        }

        private void name_textBox_TextChanged(object sender, EventArgs e)               // search for customer
        {
            try
            {
                string searchQuery = "Select Customer.customer_id, Customer.customer_name, Customer.phone, Customer.nationality, Customer.gender, Customer.birthday, Customer.personal_id, Customer.customer_address, Customer.checkin, rooms.roomNo, rooms.roomTyp, rooms.roomOptions, rooms.price from Customer inner join rooms on Customer.roomid = rooms.roomid WHERE customer_name LIKE'" + namesearch_textBox.Text + "%' and checkout = 'NO'";
                DataSet dataSet = functionClass.getData(searchQuery);
                checkout_dataGridView.DataSource = dataSet.Tables[0];

            }
            catch
            {
                error_label.Visible = true;
                checkout_button.Visible = false;
            }

        }

        int ID;
        private void checkout_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkout_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ID = int.Parse(checkout_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                nameCheckout_textBox.Text = checkout_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                roomNumbertextBox.Text = checkout_dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void checkout_button_Click(object sender, EventArgs e)
        {
            if (nameCheckout_textBox.Text.Length > 0)                        // Textbox is readonly, so checkout is only possible if customer is selected in checkout_dataGridView
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure that you want to checkout the customer: {nameCheckout_textBox.Text} with room number: {roomNumbertextBox.Text}", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string checkoutQuery = "UPDATE Customer set Checkout_exit = 'YES', checkout = '" + Checkout_dateTimePicker.Text + "' WHERE customer_id = " + ID + " UPDATE rooms set booked = 'NO' WHERE roomNo = '" + roomNumbertextBox.Text + "' ";
                    functionClass.setData(checkoutQuery, "Checkout successfully");
                    UC_Checkout_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("To checkout you need to select a customer.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void clearAll()
        {
            namesearch_textBox.Clear();
            nameCheckout_textBox.Clear();
            roomNumbertextBox.Clear();
            Checkout_dateTimePicker.ResetText();
        }

    }
}
