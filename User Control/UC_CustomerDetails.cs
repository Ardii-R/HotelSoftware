using System.Data;


namespace HotelSoftware.User_Control
{
    public partial class UC_CustomerDetails : UserControl
    {

        function functionClass = new function();

        public UC_CustomerDetails()
        {
            InitializeComponent();
            search_comboBox.SelectedIndex = 0;
        }

        private void search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;


            if (search_comboBox.SelectedIndex == 0)                     // access combobox with index
            {
                query = "Select customer.customer_id, customer.customer_name, customer.phone, customer.nationality, customer.gender, customer.birthday, customer.personal_id, customer.customer_address, customer.checkin, customer.Checkout_exit, rooms.roomNo, rooms.roomTyp, rooms.roomOptions, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid";
                executeQuery(query);

            }
            else if (search_comboBox.SelectedIndex == 1)
            {
                query = "Select customer.customer_id, customer.customer_name, customer.phone, customer.nationality, customer.gender, customer.birthday, customer.personal_id, customer.customer_address, customer.checkin, customer.checkout, rooms.roomNo, rooms.roomTyp, rooms.roomOptions, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid WHERE Checkout_exit = 'YES'";
                executeQuery(query);
            }
            else if (search_comboBox.SelectedIndex == 2)
            {
                query = "Select customer.customer_id, customer.customer_name, customer.phone, customer.nationality, customer.gender, customer.birthday, customer.personal_id, customer.customer_address, customer.checkin, customer.checkout, rooms.roomNo, rooms.roomTyp, rooms.roomOptions, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid WHERE Checkout_exit = 'NO'";
                executeQuery(query);
            }
        }


        private void executeQuery(string query)
        {
            try
            {
                DataSet dataSet = functionClass.getData(query);
                customerDetail_dataGridView.DataSource = dataSet.Tables[0];
            }
            catch
            {
                error_label.Visible = true;
                search_comboBox.SelectedIndex = -1;
            }
        }
    }
}
