namespace cafeShopManagement
{
    partial class Manager_AddUser
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
            panel_userDash = new Panel();
            button_userDetails = new Button();
            button_Manager_Back = new Button();
            button_manager_orderHistory = new Button();
            button_manager_add_user = new Button();
            label_deshboard = new Label();
            button_manager_checkFeedback = new Button();
            button_manager_Orders = new Button();
            button_manager_user = new Button();
            button_profile = new Button();
            label_manager = new Label();
            label_title = new Label();
            userDashboard_close = new Button();
            textBox_register_phone = new TextBox();
            textbox_register_address = new TextBox();
            regsiter_number = new Label();
            register_address = new Label();
            textBox_register_email = new TextBox();
            register_name_textBox = new TextBox();
            label_register_email = new Label();
            label_register_name = new Label();
            register_password = new Label();
            textBox_register_password = new TextBox();
            checkBox_register_showPassword = new CheckBox();
            textBox_register_confirm_password = new TextBox();
            register_username_textBox = new TextBox();
            label_regsiter_Confirm_password = new Label();
            label_username = new Label();
            label_Register = new Label();
            button_addUser_save = new Button();
            panel_userDash.SuspendLayout();
            SuspendLayout();
            // 
            // panel_userDash
            // 
            panel_userDash.BackColor = Color.FromArgb(111, 78, 55);
            panel_userDash.Controls.Add(button_userDetails);
            panel_userDash.Controls.Add(button_Manager_Back);
            panel_userDash.Controls.Add(button_manager_orderHistory);
            panel_userDash.Controls.Add(button_manager_add_user);
            panel_userDash.Controls.Add(label_deshboard);
            panel_userDash.Controls.Add(button_manager_checkFeedback);
            panel_userDash.Controls.Add(button_manager_Orders);
            panel_userDash.Controls.Add(button_manager_user);
            panel_userDash.Controls.Add(button_profile);
            panel_userDash.Controls.Add(label_manager);
            panel_userDash.Location = new Point(-3, -3);
            panel_userDash.Margin = new Padding(3, 4, 3, 4);
            panel_userDash.Name = "panel_userDash";
            panel_userDash.RightToLeft = RightToLeft.No;
            panel_userDash.Size = new Size(192, 800);
            panel_userDash.TabIndex = 12;
            panel_userDash.Paint += panel_userDash_Paint;
            // 
            // button_userDetails
            // 
            button_userDetails.BackColor = Color.FromArgb(111, 78, 55);
            button_userDetails.BackgroundImageLayout = ImageLayout.None;
            button_userDetails.FlatStyle = FlatStyle.Flat;
            button_userDetails.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_userDetails.ForeColor = Color.White;
            button_userDetails.Location = new Point(15, 559);
            button_userDetails.Margin = new Padding(3, 4, 3, 4);
            button_userDetails.Name = "button_userDetails";
            button_userDetails.Size = new Size(157, 40);
            button_userDetails.TabIndex = 20;
            button_userDetails.Text = "User Details";
            button_userDetails.UseVisualStyleBackColor = false;
            button_userDetails.Click += button_userDetails_Click;
            // 
            // button_Manager_Back
            // 
            button_Manager_Back.BackColor = Color.FromArgb(111, 78, 55);
            button_Manager_Back.BackgroundImageLayout = ImageLayout.None;
            button_Manager_Back.FlatStyle = FlatStyle.Flat;
            button_Manager_Back.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Manager_Back.ForeColor = Color.White;
            button_Manager_Back.Location = new Point(46, 747);
            button_Manager_Back.Margin = new Padding(3, 4, 3, 4);
            button_Manager_Back.Name = "button_Manager_Back";
            button_Manager_Back.Size = new Size(109, 40);
            button_Manager_Back.TabIndex = 19;
            button_Manager_Back.Text = "Back";
            button_Manager_Back.UseVisualStyleBackColor = false;
            button_Manager_Back.Click += button_Manager_Back_Click;
            // 
            // button_manager_orderHistory
            // 
            button_manager_orderHistory.BackColor = Color.FromArgb(111, 78, 55);
            button_manager_orderHistory.BackgroundImageLayout = ImageLayout.None;
            button_manager_orderHistory.FlatStyle = FlatStyle.Flat;
            button_manager_orderHistory.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manager_orderHistory.ForeColor = Color.White;
            button_manager_orderHistory.Location = new Point(17, 436);
            button_manager_orderHistory.Margin = new Padding(3, 4, 3, 4);
            button_manager_orderHistory.Name = "button_manager_orderHistory";
            button_manager_orderHistory.Size = new Size(157, 40);
            button_manager_orderHistory.TabIndex = 18;
            button_manager_orderHistory.Text = "Order History";
            button_manager_orderHistory.UseVisualStyleBackColor = false;
            button_manager_orderHistory.Click += button_manager_orderHistory_Click;
            // 
            // button_manager_add_user
            // 
            button_manager_add_user.BackColor = Color.FromArgb(111, 78, 55);
            button_manager_add_user.BackgroundImageLayout = ImageLayout.None;
            button_manager_add_user.FlatStyle = FlatStyle.Flat;
            button_manager_add_user.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manager_add_user.ForeColor = Color.Black;
            button_manager_add_user.Location = new Point(15, 496);
            button_manager_add_user.Margin = new Padding(3, 4, 3, 4);
            button_manager_add_user.Name = "button_manager_add_user";
            button_manager_add_user.Size = new Size(157, 40);
            button_manager_add_user.TabIndex = 16;
            button_manager_add_user.Text = "Add User";
            button_manager_add_user.UseVisualStyleBackColor = false;
            button_manager_add_user.Click += button_manager_add_user_Click;
            // 
            // label_deshboard
            // 
            label_deshboard.AutoSize = true;
            label_deshboard.BackColor = Color.FromArgb(111, 78, 55);
            label_deshboard.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_deshboard.ForeColor = Color.White;
            label_deshboard.Location = new Point(41, 81);
            label_deshboard.Name = "label_deshboard";
            label_deshboard.Size = new Size(119, 23);
            label_deshboard.TabIndex = 15;
            label_deshboard.Text = "Deshboard";
            // 
            // button_manager_checkFeedback
            // 
            button_manager_checkFeedback.BackColor = Color.FromArgb(111, 78, 55);
            button_manager_checkFeedback.BackgroundImageLayout = ImageLayout.None;
            button_manager_checkFeedback.FlatStyle = FlatStyle.Flat;
            button_manager_checkFeedback.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manager_checkFeedback.ForeColor = Color.White;
            button_manager_checkFeedback.Location = new Point(17, 619);
            button_manager_checkFeedback.Margin = new Padding(3, 4, 3, 4);
            button_manager_checkFeedback.Name = "button_manager_checkFeedback";
            button_manager_checkFeedback.Size = new Size(157, 40);
            button_manager_checkFeedback.TabIndex = 14;
            button_manager_checkFeedback.Text = "Check Feedbacks";
            button_manager_checkFeedback.UseVisualStyleBackColor = false;
            button_manager_checkFeedback.Click += button_manager_checkFeedback_Click;
            // 
            // button_manager_Orders
            // 
            button_manager_Orders.BackColor = Color.FromArgb(111, 78, 55);
            button_manager_Orders.BackgroundImageLayout = ImageLayout.None;
            button_manager_Orders.FlatStyle = FlatStyle.Flat;
            button_manager_Orders.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manager_Orders.ForeColor = Color.White;
            button_manager_Orders.Location = new Point(17, 375);
            button_manager_Orders.Margin = new Padding(3, 4, 3, 4);
            button_manager_Orders.Name = "button_manager_Orders";
            button_manager_Orders.Size = new Size(157, 40);
            button_manager_Orders.TabIndex = 14;
            button_manager_Orders.Text = "New Order";
            button_manager_Orders.UseVisualStyleBackColor = false;
            button_manager_Orders.Click += button_manager_Orders_Click;
            // 
            // button_manager_user
            // 
            button_manager_user.BackColor = Color.FromArgb(111, 78, 55);
            button_manager_user.BackgroundImageLayout = ImageLayout.None;
            button_manager_user.FlatStyle = FlatStyle.Flat;
            button_manager_user.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manager_user.ForeColor = Color.White;
            button_manager_user.Location = new Point(17, 309);
            button_manager_user.Margin = new Padding(3, 4, 3, 4);
            button_manager_user.Name = "button_manager_user";
            button_manager_user.Size = new Size(157, 40);
            button_manager_user.TabIndex = 14;
            button_manager_user.Text = "Users List";
            button_manager_user.UseVisualStyleBackColor = false;
            button_manager_user.Click += button_manager_user_Click;
            // 
            // button_profile
            // 
            button_profile.BackColor = Color.FromArgb(111, 78, 55);
            button_profile.BackgroundImageLayout = ImageLayout.None;
            button_profile.FlatStyle = FlatStyle.Flat;
            button_profile.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_profile.ForeColor = Color.White;
            button_profile.Location = new Point(17, 245);
            button_profile.Margin = new Padding(3, 4, 3, 4);
            button_profile.Name = "button_profile";
            button_profile.Size = new Size(157, 40);
            button_profile.TabIndex = 13;
            button_profile.Text = "Profile";
            button_profile.UseVisualStyleBackColor = false;
            button_profile.Click += button_profile_Click;
            // 
            // label_manager
            // 
            label_manager.AutoSize = true;
            label_manager.BackColor = Color.FromArgb(111, 78, 55);
            label_manager.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_manager.ForeColor = Color.White;
            label_manager.Location = new Point(42, 36);
            label_manager.Name = "label_manager";
            label_manager.Size = new Size(120, 28);
            label_manager.TabIndex = 12;
            label_manager.Text = "Manager ";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_title.ForeColor = Color.FromArgb(111, 78, 55);
            label_title.Location = new Point(398, 8);
            label_title.Name = "label_title";
            label_title.Size = new Size(480, 34);
            label_title.TabIndex = 20;
            label_title.Text = "Cafe Shop Management System";
            // 
            // userDashboard_close
            // 
            userDashboard_close.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userDashboard_close.Location = new Point(997, -3);
            userDashboard_close.Margin = new Padding(3, 4, 3, 4);
            userDashboard_close.Name = "userDashboard_close";
            userDashboard_close.Size = new Size(33, 35);
            userDashboard_close.TabIndex = 21;
            userDashboard_close.Text = "X";
            userDashboard_close.UseVisualStyleBackColor = true;
            userDashboard_close.Click += userDashboard_close_Click;
            // 
            // textBox_register_phone
            // 
            textBox_register_phone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_register_phone.Location = new Point(239, 469);
            textBox_register_phone.Margin = new Padding(3, 4, 3, 4);
            textBox_register_phone.Name = "textBox_register_phone";
            textBox_register_phone.Size = new Size(295, 30);
            textBox_register_phone.TabIndex = 46;
            // 
            // textbox_register_address
            // 
            textbox_register_address.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_register_address.Location = new Point(237, 403);
            textbox_register_address.Margin = new Padding(3, 4, 3, 4);
            textbox_register_address.Name = "textbox_register_address";
            textbox_register_address.Size = new Size(295, 30);
            textbox_register_address.TabIndex = 45;
            // 
            // regsiter_number
            // 
            regsiter_number.AutoSize = true;
            regsiter_number.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regsiter_number.Location = new Point(239, 441);
            regsiter_number.Name = "regsiter_number";
            regsiter_number.Size = new Size(109, 23);
            regsiter_number.TabIndex = 44;
            regsiter_number.Text = "Phone No:";
            // 
            // register_address
            // 
            register_address.AutoSize = true;
            register_address.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_address.Location = new Point(239, 375);
            register_address.Name = "register_address";
            register_address.Size = new Size(99, 23);
            register_address.TabIndex = 43;
            register_address.Text = "Address:";
            // 
            // textBox_register_email
            // 
            textBox_register_email.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_register_email.Location = new Point(239, 337);
            textBox_register_email.Margin = new Padding(3, 4, 3, 4);
            textBox_register_email.Name = "textBox_register_email";
            textBox_register_email.Size = new Size(295, 30);
            textBox_register_email.TabIndex = 41;
            // 
            // register_name_textBox
            // 
            register_name_textBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_name_textBox.Location = new Point(237, 271);
            register_name_textBox.Margin = new Padding(3, 4, 3, 4);
            register_name_textBox.Name = "register_name_textBox";
            register_name_textBox.Size = new Size(295, 30);
            register_name_textBox.TabIndex = 40;
            // 
            // label_register_email
            // 
            label_register_email.AutoSize = true;
            label_register_email.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_register_email.Location = new Point(239, 309);
            label_register_email.Name = "label_register_email";
            label_register_email.Size = new Size(69, 23);
            label_register_email.TabIndex = 39;
            label_register_email.Text = "Email:";
            // 
            // label_register_name
            // 
            label_register_name.AutoSize = true;
            label_register_name.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_register_name.Location = new Point(239, 243);
            label_register_name.Name = "label_register_name";
            label_register_name.Size = new Size(73, 23);
            label_register_name.TabIndex = 38;
            label_register_name.Text = "Name:";
            // 
            // register_password
            // 
            register_password.AutoSize = true;
            register_password.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(239, 572);
            register_password.Name = "register_password";
            register_password.Size = new Size(118, 23);
            register_password.TabIndex = 37;
            register_password.Text = " Password:";
            // 
            // textBox_register_password
            // 
            textBox_register_password.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_register_password.Location = new Point(239, 600);
            textBox_register_password.Margin = new Padding(3, 4, 3, 4);
            textBox_register_password.Name = "textBox_register_password";
            textBox_register_password.PasswordChar = '*';
            textBox_register_password.Size = new Size(295, 30);
            textBox_register_password.TabIndex = 36;
            // 
            // checkBox_register_showPassword
            // 
            checkBox_register_showPassword.AutoSize = true;
            checkBox_register_showPassword.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox_register_showPassword.ForeColor = Color.DarkGray;
            checkBox_register_showPassword.Location = new Point(239, 711);
            checkBox_register_showPassword.Margin = new Padding(3, 4, 3, 4);
            checkBox_register_showPassword.Name = "checkBox_register_showPassword";
            checkBox_register_showPassword.Size = new Size(136, 20);
            checkBox_register_showPassword.TabIndex = 35;
            checkBox_register_showPassword.Text = "Show Password";
            checkBox_register_showPassword.UseVisualStyleBackColor = true;
            // 
            // textBox_register_confirm_password
            // 
            textBox_register_confirm_password.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_register_confirm_password.Location = new Point(239, 668);
            textBox_register_confirm_password.Margin = new Padding(3, 4, 3, 4);
            textBox_register_confirm_password.Name = "textBox_register_confirm_password";
            textBox_register_confirm_password.PasswordChar = '*';
            textBox_register_confirm_password.Size = new Size(295, 30);
            textBox_register_confirm_password.TabIndex = 34;
            // 
            // register_username_textBox
            // 
            register_username_textBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username_textBox.Location = new Point(239, 533);
            register_username_textBox.Margin = new Padding(3, 4, 3, 4);
            register_username_textBox.Name = "register_username_textBox";
            register_username_textBox.Size = new Size(295, 30);
            register_username_textBox.TabIndex = 33;
            // 
            // label_regsiter_Confirm_password
            // 
            label_regsiter_Confirm_password.AutoSize = true;
            label_regsiter_Confirm_password.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_regsiter_Confirm_password.Location = new Point(238, 639);
            label_regsiter_Confirm_password.Name = "label_regsiter_Confirm_password";
            label_regsiter_Confirm_password.Size = new Size(196, 23);
            label_regsiter_Confirm_password.TabIndex = 32;
            label_regsiter_Confirm_password.Text = "Confirm Password:";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_username.Location = new Point(239, 505);
            label_username.Name = "label_username";
            label_username.Size = new Size(117, 23);
            label_username.TabIndex = 31;
            label_username.Text = "Username:";
            // 
            // label_Register
            // 
            label_Register.AutoSize = true;
            label_Register.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Register.Location = new Point(239, 157);
            label_Register.Name = "label_Register";
            label_Register.Size = new Size(136, 28);
            label_Register.TabIndex = 30;
            label_Register.Text = "REGISTER";
            // 
            // button_addUser_save
            // 
            button_addUser_save.BackColor = Color.FromArgb(111, 78, 55);
            button_addUser_save.BackgroundImageLayout = ImageLayout.None;
            button_addUser_save.FlatStyle = FlatStyle.Flat;
            button_addUser_save.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_addUser_save.ForeColor = Color.White;
            button_addUser_save.Location = new Point(239, 740);
            button_addUser_save.Margin = new Padding(3, 4, 3, 4);
            button_addUser_save.Name = "button_addUser_save";
            button_addUser_save.Size = new Size(109, 40);
            button_addUser_save.TabIndex = 20;
            button_addUser_save.Text = "save";
            button_addUser_save.UseVisualStyleBackColor = false;
            // 
            // Manager_AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 800);
            Controls.Add(button_addUser_save);
            Controls.Add(textBox_register_phone);
            Controls.Add(textbox_register_address);
            Controls.Add(regsiter_number);
            Controls.Add(register_address);
            Controls.Add(textBox_register_email);
            Controls.Add(register_name_textBox);
            Controls.Add(label_register_email);
            Controls.Add(label_register_name);
            Controls.Add(register_password);
            Controls.Add(textBox_register_password);
            Controls.Add(checkBox_register_showPassword);
            Controls.Add(textBox_register_confirm_password);
            Controls.Add(register_username_textBox);
            Controls.Add(label_regsiter_Confirm_password);
            Controls.Add(label_username);
            Controls.Add(label_Register);
            Controls.Add(userDashboard_close);
            Controls.Add(label_title);
            Controls.Add(panel_userDash);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager_AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager_AddUser";
            Load += Manager_AddUser_Load;
            panel_userDash.ResumeLayout(false);
            panel_userDash.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_userDash;
        private Button button_manager_orderHistory;
        private Button button_manager_add_user;
        private Label label_deshboard;
        private Button button_manager_checkFeedback;
        private Button button_manager_Orders;
        private Button button_manager_user;
        private Button button_profile;
        private Label label_manager;
        private Button button_Manager_Back;
        private Label label_title;
        private Button userDashboard_close;
        private TextBox textBox_register_phone;
        private TextBox textbox_register_address;
        private Label regsiter_number;
        private Label register_address;
        private TextBox textBox_register_email;
        private TextBox register_name_textBox;
        private Label label_register_email;
        private Label label_register_name;
        private Label register_password;
        private TextBox textBox_register_password;
        private CheckBox checkBox_register_showPassword;
        private TextBox textBox_register_confirm_password;
        private TextBox register_username_textBox;
        private Label label_regsiter_Confirm_password;
        private Label label_username;
        private Label label_Register;
        private Button button_addUser_save;
        private Button button_userDetails;
    }
}