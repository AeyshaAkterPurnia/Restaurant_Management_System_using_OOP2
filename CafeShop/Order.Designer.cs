namespace cafeShopManagement
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userDashboard_close = new Button();
            panel_userDash = new Panel();
            button_feedback = new Button();
            button_user_history = new Button();
            button_user_place_order = new Button();
            button_profile = new Button();
            label1 = new Label();
            button_order_back = new Button();
            label_title = new Label();
            label2 = new Label();
            comboBox_orderPlace = new ComboBox();
            dataGridView_order = new DataGridView();
            textBox_user_orderNo = new TextBox();
            textBox_user_order_userName = new TextBox();
            button_AddToCart = new Button();
            label_yourOrder = new Label();
            label_orderAmount = new Label();
            button_placeYourOrder = new Button();
            panel_userDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).BeginInit();
            SuspendLayout();
            // 
            // userDashboard_close
            // 
            userDashboard_close.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userDashboard_close.Location = new Point(994, 3);
            userDashboard_close.Margin = new Padding(3, 4, 3, 4);
            userDashboard_close.Name = "userDashboard_close";
            userDashboard_close.Size = new Size(33, 35);
            userDashboard_close.TabIndex = 11;
            userDashboard_close.Text = "X";
            userDashboard_close.UseVisualStyleBackColor = true;
            userDashboard_close.Click += userDashboard_close_Click;
            // 
            // panel_userDash
            // 
            panel_userDash.BackColor = Color.FromArgb(111, 78, 55);
            panel_userDash.Controls.Add(button_feedback);
            panel_userDash.Controls.Add(button_user_history);
            panel_userDash.Controls.Add(button_user_place_order);
            panel_userDash.Controls.Add(button_profile);
            panel_userDash.Controls.Add(label1);
            panel_userDash.Controls.Add(button_order_back);
            panel_userDash.Location = new Point(-3, -3);
            panel_userDash.Margin = new Padding(3, 4, 3, 4);
            panel_userDash.Name = "panel_userDash";
            panel_userDash.RightToLeft = RightToLeft.No;
            panel_userDash.Size = new Size(192, 828);
            panel_userDash.TabIndex = 12;
            panel_userDash.Paint += panel_userDash_Paint;
            // 
            // button_feedback
            // 
            button_feedback.BackColor = Color.FromArgb(111, 78, 55);
            button_feedback.BackgroundImageLayout = ImageLayout.None;
            button_feedback.FlatStyle = FlatStyle.Flat;
            button_feedback.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_feedback.ForeColor = Color.White;
            button_feedback.Location = new Point(17, 460);
            button_feedback.Margin = new Padding(3, 4, 3, 4);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(157, 40);
            button_feedback.TabIndex = 14;
            button_feedback.Text = "Feedback";
            button_feedback.UseVisualStyleBackColor = false;
            button_feedback.Click += button_feedback_Click;
            // 
            // button_user_history
            // 
            button_user_history.BackColor = Color.FromArgb(111, 78, 55);
            button_user_history.BackgroundImageLayout = ImageLayout.None;
            button_user_history.FlatStyle = FlatStyle.Flat;
            button_user_history.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_user_history.ForeColor = Color.White;
            button_user_history.Location = new Point(17, 399);
            button_user_history.Margin = new Padding(3, 4, 3, 4);
            button_user_history.Name = "button_user_history";
            button_user_history.Size = new Size(157, 40);
            button_user_history.TabIndex = 14;
            button_user_history.Text = "Order History";
            button_user_history.UseVisualStyleBackColor = false;
            button_user_history.Click += button_user_history_Click;
            // 
            // button_user_place_order
            // 
            button_user_place_order.BackColor = Color.FromArgb(111, 78, 55);
            button_user_place_order.BackgroundImageLayout = ImageLayout.None;
            button_user_place_order.FlatStyle = FlatStyle.Flat;
            button_user_place_order.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_user_place_order.ForeColor = Color.Black;
            button_user_place_order.Location = new Point(17, 339);
            button_user_place_order.Margin = new Padding(3, 4, 3, 4);
            button_user_place_order.Name = "button_user_place_order";
            button_user_place_order.Size = new Size(157, 40);
            button_user_place_order.TabIndex = 14;
            button_user_place_order.Text = "Place Order";
            button_user_place_order.UseVisualStyleBackColor = false;
            // 
            // button_profile
            // 
            button_profile.BackColor = Color.FromArgb(111, 78, 55);
            button_profile.BackgroundImageLayout = ImageLayout.None;
            button_profile.FlatStyle = FlatStyle.Flat;
            button_profile.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_profile.ForeColor = Color.White;
            button_profile.Location = new Point(17, 276);
            button_profile.Margin = new Padding(3, 4, 3, 4);
            button_profile.Name = "button_profile";
            button_profile.Size = new Size(157, 40);
            button_profile.TabIndex = 13;
            button_profile.Text = "Profile";
            button_profile.UseVisualStyleBackColor = false;
            button_profile.Click += button_profile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(111, 78, 55);
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 36);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 12;
            label1.Text = "User Deshboard";
            // 
            // button_order_back
            // 
            button_order_back.BackColor = Color.FromArgb(111, 78, 55);
            button_order_back.BackgroundImageLayout = ImageLayout.None;
            button_order_back.FlatStyle = FlatStyle.Flat;
            button_order_back.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_order_back.ForeColor = Color.White;
            button_order_back.Location = new Point(46, 747);
            button_order_back.Margin = new Padding(3, 4, 3, 4);
            button_order_back.Name = "button_order_back";
            button_order_back.Size = new Size(85, 40);
            button_order_back.TabIndex = 12;
            button_order_back.Text = "Back";
            button_order_back.UseVisualStyleBackColor = false;
            button_order_back.Click += button_order_back_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_title.ForeColor = Color.FromArgb(111, 78, 55);
            label_title.Location = new Point(398, 8);
            label_title.Name = "label_title";
            label_title.Size = new Size(480, 34);
            label_title.TabIndex = 13;
            label_title.Text = "Cafe Shop Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(498, 75);
            label2.Name = "label2";
            label2.Size = new Size(156, 34);
            label2.TabIndex = 14;
            label2.Text = "Place Order";
            // 
            // comboBox_orderPlace
            // 
            comboBox_orderPlace.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_orderPlace.FormattingEnabled = true;
            comboBox_orderPlace.Items.AddRange(new object[] { "Food", "Beverage" });
            comboBox_orderPlace.Location = new Point(216, 165);
            comboBox_orderPlace.Margin = new Padding(3, 4, 3, 4);
            comboBox_orderPlace.Name = "comboBox_orderPlace";
            comboBox_orderPlace.Size = new Size(134, 30);
            comboBox_orderPlace.TabIndex = 15;
            comboBox_orderPlace.Text = "Category";
            // 
            // dataGridView_order
            // 
            dataGridView_order.BackgroundColor = Color.White;
            dataGridView_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_order.GridColor = Color.White;
            dataGridView_order.Location = new Point(408, 457);
            dataGridView_order.Margin = new Padding(3, 4, 3, 4);
            dataGridView_order.Name = "dataGridView_order";
            dataGridView_order.RowHeadersWidth = 51;
            dataGridView_order.Size = new Size(607, 249);
            dataGridView_order.TabIndex = 16;
            // 
            // textBox_user_orderNo
            // 
            textBox_user_orderNo.BackColor = SystemColors.Control;
            textBox_user_orderNo.BorderStyle = BorderStyle.None;
            textBox_user_orderNo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_user_orderNo.Location = new Point(216, 220);
            textBox_user_orderNo.Margin = new Padding(3, 4, 3, 4);
            textBox_user_orderNo.Name = "textBox_user_orderNo";
            textBox_user_orderNo.Size = new Size(135, 18);
            textBox_user_orderNo.TabIndex = 17;
            textBox_user_orderNo.Text = "Order No: ";
            // 
            // textBox_user_order_userName
            // 
            textBox_user_order_userName.BackColor = SystemColors.Control;
            textBox_user_order_userName.BorderStyle = BorderStyle.None;
            textBox_user_order_userName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_user_order_userName.Location = new Point(216, 259);
            textBox_user_order_userName.Margin = new Padding(3, 4, 3, 4);
            textBox_user_order_userName.Name = "textBox_user_order_userName";
            textBox_user_order_userName.Size = new Size(135, 18);
            textBox_user_order_userName.TabIndex = 18;
            textBox_user_order_userName.Text = "UserName: ";
            // 
            // button_AddToCart
            // 
            button_AddToCart.BackColor = Color.FromArgb(111, 78, 55);
            button_AddToCart.BackgroundImageLayout = ImageLayout.None;
            button_AddToCart.FlatStyle = FlatStyle.Flat;
            button_AddToCart.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_AddToCart.ForeColor = Color.White;
            button_AddToCart.Location = new Point(216, 297);
            button_AddToCart.Margin = new Padding(3, 4, 3, 4);
            button_AddToCart.Name = "button_AddToCart";
            button_AddToCart.Size = new Size(157, 40);
            button_AddToCart.TabIndex = 15;
            button_AddToCart.Text = "Add To Cart";
            button_AddToCart.UseVisualStyleBackColor = false;
            // 
            // label_yourOrder
            // 
            label_yourOrder.AutoSize = true;
            label_yourOrder.BackColor = Color.FromArgb(111, 78, 55);
            label_yourOrder.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_yourOrder.ForeColor = Color.White;
            label_yourOrder.Location = new Point(655, 416);
            label_yourOrder.Name = "label_yourOrder";
            label_yourOrder.Size = new Size(151, 34);
            label_yourOrder.TabIndex = 19;
            label_yourOrder.Text = "Your Order";
            label_yourOrder.Click += label3_Click;
            // 
            // label_orderAmount
            // 
            label_orderAmount.AutoSize = true;
            label_orderAmount.BackColor = Color.White;
            label_orderAmount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_orderAmount.ForeColor = Color.FromArgb(111, 78, 55);
            label_orderAmount.Location = new Point(880, 756);
            label_orderAmount.Name = "label_orderAmount";
            label_orderAmount.Size = new Size(151, 27);
            label_orderAmount.TabIndex = 20;
            label_orderAmount.Text = "Order Amount";
            // 
            // button_placeYourOrder
            // 
            button_placeYourOrder.BackColor = Color.FromArgb(111, 78, 55);
            button_placeYourOrder.BackgroundImageLayout = ImageLayout.None;
            button_placeYourOrder.FlatStyle = FlatStyle.Flat;
            button_placeYourOrder.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_placeYourOrder.ForeColor = Color.White;
            button_placeYourOrder.Location = new Point(430, 744);
            button_placeYourOrder.Margin = new Padding(3, 4, 3, 4);
            button_placeYourOrder.Name = "button_placeYourOrder";
            button_placeYourOrder.Size = new Size(201, 44);
            button_placeYourOrder.TabIndex = 21;
            button_placeYourOrder.Text = "Place Your Order";
            button_placeYourOrder.UseVisualStyleBackColor = false;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 800);
            Controls.Add(button_placeYourOrder);
            Controls.Add(label_orderAmount);
            Controls.Add(label_yourOrder);
            Controls.Add(button_AddToCart);
            Controls.Add(textBox_user_order_userName);
            Controls.Add(textBox_user_orderNo);
            Controls.Add(dataGridView_order);
            Controls.Add(comboBox_orderPlace);
            Controls.Add(label2);
            Controls.Add(label_title);
            Controls.Add(panel_userDash);
            Controls.Add(userDashboard_close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += Order_Load;
            panel_userDash.ResumeLayout(false);
            panel_userDash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button userDashboard_close;
        private Panel panel_userDash;
        private Button button_feedback;
        private Button button_user_history;
        private Button button_user_place_order;
        private Button button_profile;
        private Label label1;
        private Button button_order_back;
        private Label label_title;
        private Label label2;
        private ComboBox comboBox_orderPlace;
        private DataGridView dataGridView_order;
        private TextBox textBox_user_orderNo;
        private TextBox textBox_user_order_userName;
        private Button button_AddToCart;
        private Label label_yourOrder;
        private Label label_orderAmount;
        private Button button_placeYourOrder;
    }
}