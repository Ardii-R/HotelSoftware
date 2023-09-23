using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSoftware.User_Control
{
    public partial class UC_CustomerDetails : UserControl
    {

        function functionClass = new function();
        DataSet dataSet = new DataSet();

        public UC_CustomerDetails()
        {
            InitializeComponent();
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
                query = "Select customer.customer_id, customer.customer_name, customer.phone, customer.nationality, customer.gender, customer.birthday, customer.personal_id, customer.customer_address, customer.checkin, customer.checkout, rooms.roomNo, rooms.roomTyp, rooms.roomOptions, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid WHERE checkout is not NULL";
                executeQuery(query);
            }
            else if (search_comboBox.SelectedIndex == 2)
            {
                query = "Select customer.customer_id, customer.customer_name, customer.phone, customer.nationality, customer.gender, customer.birthday, customer.personal_id, customer.customer_address, customer.checkin, customer.checkout, rooms.roomNo, rooms.roomTyp, rooms.roomOptions, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid WHERE checkout is NULL";
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
