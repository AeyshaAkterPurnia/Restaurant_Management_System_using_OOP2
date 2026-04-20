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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void panel_userDash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_order_back_Click(object sender, EventArgs e)
        {
            UserDeshboard u1 = new UserDeshboard();
            u1.Show();
            this.Hide();
        }

        private void userDashboard_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            Profile p1 = new Profile();
            p1.Show();
            this.Hide();
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

        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
