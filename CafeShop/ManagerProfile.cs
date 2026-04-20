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
    public partial class ManagerProfile : Form
    {
        public ManagerProfile()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U9LBISC\\SQLEXPRESS;Initial Catalog=\"cafe 1\";Integrated Security=True;Trust Server Certificate=True");

        private void userDashboard_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Manager_Back_Click(object sender, EventArgs e)
        {
            ManagerDeshboard managerDeshboard = new ManagerDeshboard();
            managerDeshboard.Show();
            this.Hide();
        }

        private void button_manager_user_Click(object sender, EventArgs e)
        {
            Manager_userList manager_UserList = new Manager_userList();
            manager_UserList.Show();
            this.Hide();
        }

        private void button_manager_Orders_Click(object sender, EventArgs e)
        {
            Manager_newOrders newOrder = new Manager_newOrders();
            newOrder.Show();
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

        private void ManagerProfile_Load(object sender, EventArgs e)
        {

            //string name = UserSession.UserName;
            string query = "select * from registration where username =  '" + UserSession.UserName + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            sda.Fill(dt);


            if (dt.Rows.Count == 1)

            {
                textBox_name.Text = dt.Rows[0][1].ToString();
                textBox_name.ReadOnly = true;

                textBox3_dateOfBirth.Text = dt.Rows[0][4].ToString();
                textBox3_dateOfBirth.ReadOnly = true;

                textBox2_contact.Text = dt.Rows[0][5].ToString();
                textBox2_contact.ReadOnly = true;

                textBox4_email.Text = dt.Rows[0][2].ToString();
                textBox4_email.ReadOnly = true;

                textBox5_address.Text = dt.Rows[0][3].ToString();
                textBox5_address.ReadOnly = true;


                textBox6_username.Text = dt.Rows[0][6].ToString();
                textBox6_username.ReadOnly = true;




            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Update_Click(object sender, EventArgs e)
        {

            if (textBox_oldPassword.Text == "")
            {
                MessageBox.Show("Enter old password to change the password");
                textBox_oldPassword.Focus();
            }

            else
            {
                if (textBox_oldPassword.Text == UserSession.Password)
                {
                    if (textBox8_newPassword.Text == "")
                    {
                        MessageBox.Show("Enter new password to change the old one");
                        textBox8_newPassword.Focus();


                    }

                    else
                    {

                        string update_query = "update registration set password ='" + textBox8_newPassword.Text + "' where username ='" + UserSession.UserName + "'";

                        SqlCommand cmd = new SqlCommand(update_query, con);
                        if (con.State == ConnectionState.Closed)
                        {

                            con.Open();

                        }
                        if (con.State == ConnectionState.Open)
                        {
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("password change successfull");
                                textBox8_newPassword.Clear();
                                textBox_oldPassword.Clear();

                            }

                            else
                            {
                                MessageBox.Show("password change  not successfull ...... try again");


                            }

                        }


                    }


                }
                else
                {
                    MessageBox.Show("wrong password..... enter the right password for changing the password of " + UserSession.UserName);
                }

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
