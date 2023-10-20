using HotelSoftware.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;


namespace HotelSoftware
{
    public partial class Dashboard : Form
    {
        private System.Drawing.Point position;

        public Dashboard()
        {
            InitializeComponent();
            UC_AddRooms uc_AddRooms = new UC_AddRooms();
            addUserControl(uc_AddRooms);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            uc_dashboardPanel.Controls.Clear();
            uc_dashboardPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void closing_button_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void addRooms_RaidioButton_CheckedChanged(object sender, EventArgs e)
        {
            underline_panel.Left = addRooms_RaidioButton.Left;
            UC_AddRooms uc_AddRooms = new UC_AddRooms();
            addUserControl(uc_AddRooms);

            if (addRooms_RaidioButton.Checked)
            {
                addRooms_RaidioButton.BackColor = Color.White;
            }
            else
            {
                addRooms_RaidioButton.BackColor = Color.FromArgb(19, 15, 64);
                addRooms_RaidioButton.ForeColor = Color.White;
            }
        }

        private void addRooms_RaidioButton_MouseHover(object sender, EventArgs e)
        {
            position = underline_panel.Location;
            underline_panel.Left = addRooms_RaidioButton.Left;

            if (!addRooms_RaidioButton.Checked)
            {
                addRooms_RaidioButton.BackColor = Color.White;
                addRooms_RaidioButton.ForeColor = Color.Black;
            }
        }

        private void addRooms_RaidioButton_MouseLeave(object sender, EventArgs e)
        {
            if (addRooms_RaidioButton.Checked == false)
            {
                underline_panel.Location = position;
                addRooms_RaidioButton.BackColor = Color.FromArgb(19, 15, 64);
                addRooms_RaidioButton.ForeColor = Color.White;
            }
        }


        private void customerRegistration_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            underline_panel.Left = customerRegistration_radioButton.Left;

            UC_CustomerRegistration uc_Customer = new UC_CustomerRegistration();
            addUserControl(uc_Customer);

            if (customerRegistration_radioButton.Checked)
            {
                customerRegistration_radioButton.BackColor = Color.White;
                customerRegistration_radioButton.ForeColor = Color.Black;
            }
            else
            {
                customerRegistration_radioButton.BackColor = Color.FromArgb(19, 15, 64);
                customerRegistration_radioButton.ForeColor = Color.White;
            }
        }

        private void customerRegistration_radioButton_MouseHover(object sender, EventArgs e)
        {
            position = underline_panel.Location;
            underline_panel.Left = customerRegistration_radioButton.Left;

            if (!customerRegistration_radioButton.Checked)
            {
                customerRegistration_radioButton.BackColor = Color.White;
                customerRegistration_radioButton.ForeColor = Color.Black;
            }
        }

        private void customerRegistration_radioButton_MouseLeave(object sender, EventArgs e)
        {
            if (customerRegistration_radioButton.Checked == false)
            {
                underline_panel.Location = position;
                customerRegistration_radioButton.BackColor = Color.FromArgb(19, 15, 64);
                customerRegistration_radioButton.ForeColor = Color.White;
            }
        }

        private void CheckOut_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            underline_panel.Left = CheckOut_radioButton.Left;

            UC_Checkout uC_Checkout = new UC_Checkout();
            addUserControl(uC_Checkout);


            if (CheckOut_radioButton.Checked)
            {
                CheckOut_radioButton.BackColor = Color.White;
            }
            else
            {
                CheckOut_radioButton.BackColor = Color.FromArgb(19, 15, 64);
                CheckOut_radioButton.ForeColor = Color.White;
            }
        }

        private void CheckOut_radioButton_MouseHover(object sender, EventArgs e)
        {
            position = underline_panel.Location;
            underline_panel.Left = CheckOut_radioButton.Left;

            if (!CheckOut_radioButton.Checked)
            {
                CheckOut_radioButton.BackColor = Color.White;
                CheckOut_radioButton.ForeColor = Color.Black;
            }
        }

        private void CheckOut_radioButton_MouseLeave(object sender, EventArgs e)
        {
            if (CheckOut_radioButton.Checked == false)
            {
                underline_panel.Location = position;
                CheckOut_radioButton.BackColor = Color.FromArgb(19, 15, 64);
                CheckOut_radioButton.ForeColor = Color.White;
            }
        }



        private void CustomerDetails_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            underline_panel.Left = CustomerDetails_radioButton.Left;

            UC_CustomerDetails uc_CustomerDetails = new UC_CustomerDetails();
            addUserControl(uc_CustomerDetails);

            if (CustomerDetails_radioButton.Checked)
            {
                CustomerDetails_radioButton.BackColor = Color.White;
            }
            else
            {
                CustomerDetails_radioButton.BackColor = Color.FromArgb(19, 15, 64);
                CustomerDetails_radioButton.ForeColor = Color.White;
            }
        }

        private void CustomerDetails_radioButton_MouseHover(object sender, EventArgs e)
        {
            position = underline_panel.Location;
            underline_panel.Left = CustomerDetails_radioButton.Left; ;

            if (!CustomerDetails_radioButton.Checked)
            {
                CustomerDetails_radioButton.BackColor = Color.White;
                CustomerDetails_radioButton.ForeColor = Color.Black;
            }
        }

        private void CustomerDetails_radioButton_MouseLeave(object sender, EventArgs e)
        {
            if (CustomerDetails_radioButton.Checked == false)
            {
                underline_panel.Location = position;
                CustomerDetails_radioButton.BackColor = Color.FromArgb(19, 15, 64);
                CustomerDetails_radioButton.ForeColor = Color.White;
            }
        }


        private void employee_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            underline_panel.Left = employee_radioButton.Left;

            UC_Employee uC_Employee = new UC_Employee();
            addUserControl(uC_Employee);

            if (employee_radioButton.Checked)
            {
                employee_radioButton.BackColor = Color.White;
            }
            else
            {
                employee_radioButton.BackColor = Color.FromArgb(19, 15, 64);
                employee_radioButton.ForeColor = Color.White;
            }
        }


        private void employee_radioButton_MouseHover(object sender, EventArgs e)
        {
            position = underline_panel.Location;
            underline_panel.Left = employee_radioButton.Left;

            if (!employee_radioButton.Checked)
            {
                employee_radioButton.BackColor = Color.White;
                employee_radioButton.ForeColor = Color.Black;
            }
        }

        private void employee_radioButton_MouseLeave(object sender, EventArgs e)
        {
            if (employee_radioButton.Checked == false)
            {
                underline_panel.Location = position;
                employee_radioButton.BackColor = Color.FromArgb(19, 15, 64);
                employee_radioButton.ForeColor = Color.White;
            }
        }


    }
}
