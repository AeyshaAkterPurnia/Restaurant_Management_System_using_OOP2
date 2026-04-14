using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeShopManagement
{
    public partial class Manager_orderHistory : Form
    {
        public Manager_orderHistory()
        {
            InitializeComponent();
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            ManagerProfile m1 = new ManagerProfile();
            m1.Show();
            this.Hide();
        }

        private void button_manager_user_Click(object sender, EventArgs e)
        {
            Manager_userList manager_UserList = new Manager_userList();
            manager_UserList.Show();
            manager_UserList.Hide();
        }

        private void userDashboard_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Manager_Back_Click(object sender, EventArgs e)
        {
            ManagerDeshboard m1 = new ManagerDeshboard();
            m1.Show();
            m1.Hide();
        }

        private void button_manager_Orders_Click(object sender, EventArgs e)
        {
            Manager_newOrders manager_NewOrders = new Manager_newOrders();
            manager_NewOrders.Show();
            this.Hide();
        }

        private void button_manager_add_user_Click(object sender, EventArgs e)
        {
            Manager_AddUser addUser = new Manager_AddUser();
            addUser.Show();
            this.Hide();
        }

        private void button_manager_add_deliveryMan_Click(object sender, EventArgs e)
        {

        }

        private void button_manager_checkFeedback_Click(object sender, EventArgs e)
        {
            Manager_checkFeedbacks manager_CheckFeedbacks = new Manager_checkFeedbacks();
            manager_CheckFeedbacks.Show();
            this.Hide();
        }

        private void button_userDetails_Click(object sender, EventArgs e)
        {
            Manager_userDetails m1 = new Manager_userDetails();
            m1.Show();
            this.Hide();
        }

        private void Manager_orderHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
