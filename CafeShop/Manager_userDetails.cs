using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace cafeShopManagement
{
    public partial class Manager_userDetails : Form
    {
        public Manager_userDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U9LBISC\\SQLEXPRESS;Initial Catalog=\"cafe 1\";Integrated Security=True;Trust Server Certificate=True");

        private void button_userDetails_Click(object sender, EventArgs e)
        {

        }

        private void Manager_userDetails_Load(object sender, EventArgs e)
        {
            string querey = "select id,username,role,name,email,phone,address from registration";
            SqlDataAdapter sda = new SqlDataAdapter(querey, con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_userDetails.DataSource = dt;
        }

        private void userDashboard_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
           
        }

        private void button_manager_user_Click(object sender, EventArgs e)
        {
           
        }

        private void button_manager_Orders_Click(object sender, EventArgs e)
        {
        }

        private void button_manager_orderHistory_Click(object sender, EventArgs e)
        {
           
        }

        private void button_manager_add_user_Click(object sender, EventArgs e)
        {


        }

        private void button_manager_checkFeedback_Click(object sender, EventArgs e)
        {

        }

        private void button_Manager_Back_Click(object sender, EventArgs e)
        {
           
        }

        private void button_manager_checkFeedback_Click_1(object sender, EventArgs e)
        {
            Manager_checkFeedbacks manager_CheckFeedbacks = new Manager_checkFeedbacks();
            manager_CheckFeedbacks.Show();
            this.Hide();
        }

        private void button_manager_add_user_Click_1(object sender, EventArgs e)
        {
            Manager_AddUser manager_AddUser = new Manager_AddUser();
            manager_AddUser.Show();
            this.Hide();
        }

        private void button_manager_Orders_Click_1(object sender, EventArgs e)
        {
            Manager_newOrders manager_NewOrders = new Manager_newOrders();
            manager_NewOrders.Show();
            this.Hide();
        }

        private void button_manager_orderHistory_Click_1(object sender, EventArgs e)
        {
            Manager_orderHistory manager_OrderHistory = new Manager_orderHistory();
            manager_OrderHistory.Show();
            this.Hide();
        }

        private void button_manager_user_Click_1(object sender, EventArgs e)
        {
            Manager_userList manager_UserList = new Manager_userList();
            manager_UserList.Show();
            this.Hide();

        }

        private void button_profile_Click_1(object sender, EventArgs e)
        {
            ManagerProfile managerProfile = new ManagerProfile();
            managerProfile.Show();
            this.Hide();

        }

        private void button_Manager_Back_Click_1(object sender, EventArgs e)
        {
            ManagerDeshboard managerDeshboard = new ManagerDeshboard();
            managerDeshboard.Show();
            this.Hide();

        }
    }
}
