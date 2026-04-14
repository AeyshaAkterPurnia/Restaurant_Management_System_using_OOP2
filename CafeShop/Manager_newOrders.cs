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
    public partial class Manager_newOrders : Form
    {
        public Manager_newOrders()
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
            this.Hide();
        }

        private void userDashboard_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Manager_Back_Click(object sender, EventArgs e)
        {
            ManagerDeshboard m1 = new ManagerDeshboard();
            m1.Show();
            this.Hide();
        }

        private void label_newOrder_Click(object sender, EventArgs e)
        {

        }

        private void button_manager_orderHistory_Click(object sender, EventArgs e)
        {
            Manager_orderHistory m1 = new Manager_orderHistory();
            m1.Show();
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

        private void Manager_newOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
