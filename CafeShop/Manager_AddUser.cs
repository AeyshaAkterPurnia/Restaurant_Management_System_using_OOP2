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
    public partial class Manager_AddUser : Form
    {
        public Manager_AddUser()
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

        private void button_manager_add_user_Click(object sender, EventArgs e)
        {

        }

        private void panel_userDash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_manager_Orders_Click(object sender, EventArgs e)
        {
            Manager_newOrders m1 = new Manager_newOrders();
            m1.Show();
            this.Hide();
        }

        private void button_manager_orderHistory_Click(object sender, EventArgs e)
        {
            Manager_orderHistory m1 = new Manager_orderHistory();
            m1.Show();
            this.Hide();
        }

        private void button_manager_add_deliveryMan_Click(object sender, EventArgs e)
        {

        }

        private void button_manager_checkFeedback_Click(object sender, EventArgs e)
        {
            Manager_checkFeedbacks m1 = new Manager_checkFeedbacks();
            m1.Show();
            this.Hide();
        }

        private void button_userDetails_Click(object sender, EventArgs e)
        {
            Manager_userDetails m1 = new Manager_userDetails();
            m1.Show();
            this.Hide();
        }

        private void Manager_AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
