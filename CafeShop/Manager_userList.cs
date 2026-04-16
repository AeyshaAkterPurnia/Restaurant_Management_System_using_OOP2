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
    public partial class Manager_userList : Form
    {
        public Manager_userList()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U9LBISC\\SQLEXPRESS;Initial Catalog=\"cafe 1\";Integrated Security=True;Trust Server Certificate=True");


        private void button_profile_Click(object sender, EventArgs e)
        {
            ManagerProfile m1 = new ManagerProfile();
            m1.Show();
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
            m1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_manager_Orders_Click(object sender, EventArgs e)
        {
            Manager_newOrders manager_NewOrders = new Manager_newOrders();
            manager_NewOrders.Show();
            this.Hide();
        }

        private void button_manager_orderHistory_Click(object sender, EventArgs e)
        {
            Manager_orderHistory history = new Manager_orderHistory();
            history.Show();
            this.Hide();
        }

        private void button_manager_add_user_Click(object sender, EventArgs e)
        {
            Manager_AddUser user = new Manager_AddUser();
            user.Show();
            this.Hide();
        }

        private void button_manager_add_deliveryMan_Click(object sender, EventArgs e)
        {

        }

        private void button_manager_checkFeedback_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_manager_user_Click(object sender, EventArgs e)
        {

        }

        private void Manager_userList_Load(object sender, EventArgs e)
        {
            string querey = "select id,username,role,status from registration";
            SqlDataAdapter sda = new SqlDataAdapter(querey, con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button_userDetails_Click(object sender, EventArgs e)
        {
            Manager_userDetails m1 = new Manager_userDetails();
            m1.Show();
            this.Hide();
        }
    }
}
