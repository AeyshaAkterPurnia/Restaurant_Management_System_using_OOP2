using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace cafeShopManagement
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U9LBISC\\SQLEXPRESS;Initial Catalog=\"cafe 1\";Integrated Security=True;Trust Server Certificate=True");

        private void panel_userDash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userDashboard_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_order_back_Click(object sender, EventArgs e)
        {
            UserDeshboard u1 = new UserDeshboard();
            u1.Show();
            this.Hide();
        }

        private void button_user_place_order_Click(object sender, EventArgs e)
        {
            Order o1 = new Order();
            o1.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_yourProfile_Click(object sender, EventArgs e)
        {

        }

        private void label_profile_number_Click(object sender, EventArgs e)
        {

        }

        private void label_profile_mail_Click(object sender, EventArgs e)
        {

        }

        private void label_profile_address_Click(object sender, EventArgs e)
        {

        }

        private void label_profile_login_Click(object sender, EventArgs e)
        {

        }

        private void button_profile_Click(object sender, EventArgs e)
        {

        }

        private void panel_userDash_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button_user_place_order_Click_1(object sender, EventArgs e)
        {
            Order o1 = new Order();
            o1.Show();
            this.Hide();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox7_oldPassword.Text == "") 
            {
                MessageBox.Show("Enter old password to change the password");
                textBox7_oldPassword.Focus();
            }

            else 
            {
                if (textBox7_oldPassword.Text == UserSession.Password)
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
                                textBox7_oldPassword.Clear();

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

        private void label_profile_birthday_Click(object sender, EventArgs e)
        {

        }

        private void button_order_back_Click_1(object sender, EventArgs e)
        {
            UserDeshboard u1 = new UserDeshboard();
            u1.Show();
            this.Hide();
        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void button_user_history_Click(object sender, EventArgs e)
        {
            UserHistory u1 = new UserHistory();
            u1.Show();
            this.Hide();
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            Feedback f1 = new Feedback();
            f1.Show();
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            string query = "select * from registration where username =  '" + UserSession.UserName + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            sda.Fill(dt);


            if (dt.Rows.Count == 1)

            {
                textBox_name.Text = dt.Rows[0][1].ToString();
                textBox_name.ReadOnly = true;

                textBox3_date.Text = dt.Rows[0][4].ToString();
                textBox3_date.ReadOnly = true;

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
    }
}
