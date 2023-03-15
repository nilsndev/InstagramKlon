namespace RealInstagram.Forms
{
    partial class Login_Form
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
            this.login_button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.login_tabPage1 = new System.Windows.Forms.TabPage();
            this.login_head_label1 = new System.Windows.Forms.Label();
            this.create_account_label1 = new System.Windows.Forms.Label();
            this.password_label1 = new System.Windows.Forms.Label();
            this.login_password_textBox1 = new System.Windows.Forms.TextBox();
            this.username_label1 = new System.Windows.Forms.Label();
            this.login_user_name_textBox1 = new System.Windows.Forms.TextBox();
            this.register_tabPage2 = new System.Windows.Forms.TabPage();
            this.register_head_label1 = new System.Windows.Forms.Label();
            this.rewiew_password_label1 = new System.Windows.Forms.Label();
            this.rewiew_password_textBox1 = new System.Windows.Forms.TextBox();
            this.register_button1 = new System.Windows.Forms.Button();
            this.first_name_label4 = new System.Windows.Forms.Label();
            this.first_name_textBox4 = new System.Windows.Forms.TextBox();
            this.last_name_label3 = new System.Windows.Forms.Label();
            this.last_name_textBox3 = new System.Windows.Forms.TextBox();
            this.reg_pass_label1 = new System.Windows.Forms.Label();
            this.register_password_textBox1 = new System.Windows.Forms.TextBox();
            this.reg_username_label2 = new System.Windows.Forms.Label();
            this.register_username_textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.login_tabPage1.SuspendLayout();
            this.register_tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button1
            // 
            this.login_button1.Location = new System.Drawing.Point(72, 482);
            this.login_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_button1.Name = "login_button1";
            this.login_button1.Size = new System.Drawing.Size(348, 95);
            this.login_button1.TabIndex = 0;
            this.login_button1.Text = "Login";
            this.login_button1.UseVisualStyleBackColor = true;
            this.login_button1.Click += new System.EventHandler(this.login_button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.login_tabPage1);
            this.tabControl1.Controls.Add(this.register_tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 644);
            this.tabControl1.TabIndex = 1;
            // 
            // login_tabPage1
            // 
            this.login_tabPage1.Controls.Add(this.login_head_label1);
            this.login_tabPage1.Controls.Add(this.create_account_label1);
            this.login_tabPage1.Controls.Add(this.password_label1);
            this.login_tabPage1.Controls.Add(this.login_password_textBox1);
            this.login_tabPage1.Controls.Add(this.username_label1);
            this.login_tabPage1.Controls.Add(this.login_user_name_textBox1);
            this.login_tabPage1.Controls.Add(this.login_button1);
            this.login_tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_tabPage1.Location = new System.Drawing.Point(4, 4);
            this.login_tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_tabPage1.Name = "login_tabPage1";
            this.login_tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_tabPage1.Size = new System.Drawing.Size(597, 615);
            this.login_tabPage1.TabIndex = 0;
            this.login_tabPage1.Text = "Login";
            this.login_tabPage1.UseVisualStyleBackColor = true;
            this.login_tabPage1.Click += new System.EventHandler(this.login_tabPage1_Click);
            // 
            // login_head_label1
            // 
            this.login_head_label1.AutoSize = true;
            this.login_head_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_head_label1.Location = new System.Drawing.Point(-116, 48);
            this.login_head_label1.Name = "login_head_label1";
            this.login_head_label1.Size = new System.Drawing.Size(717, 31);
            this.login_head_label1.TabIndex = 14;
            this.login_head_label1.Text = "(LOGIN) Delete reaction, comment when deleting post";
            this.login_head_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // create_account_label1
            // 
            this.create_account_label1.AutoSize = true;
            this.create_account_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_account_label1.ForeColor = System.Drawing.Color.Blue;
            this.create_account_label1.Location = new System.Drawing.Point(159, 415);
            this.create_account_label1.Name = "create_account_label1";
            this.create_account_label1.Size = new System.Drawing.Size(176, 29);
            this.create_account_label1.TabIndex = 13;
            this.create_account_label1.Text = "Create Account";
            this.create_account_label1.Click += new System.EventHandler(this.create_account_label1_Click);
            // 
            // password_label1
            // 
            this.password_label1.AutoSize = true;
            this.password_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label1.Location = new System.Drawing.Point(49, 274);
            this.password_label1.Name = "password_label1";
            this.password_label1.Size = new System.Drawing.Size(126, 29);
            this.password_label1.TabIndex = 4;
            this.password_label1.Text = "Password:";
            // 
            // login_password_textBox1
            // 
            this.login_password_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password_textBox1.Location = new System.Drawing.Point(53, 340);
            this.login_password_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_password_textBox1.Name = "login_password_textBox1";
            this.login_password_textBox1.Size = new System.Drawing.Size(401, 34);
            this.login_password_textBox1.TabIndex = 3;
            this.login_password_textBox1.UseSystemPasswordChar = true;
            // 
            // username_label1
            // 
            this.username_label1.AutoSize = true;
            this.username_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label1.Location = new System.Drawing.Point(45, 155);
            this.username_label1.Name = "username_label1";
            this.username_label1.Size = new System.Drawing.Size(130, 29);
            this.username_label1.TabIndex = 2;
            this.username_label1.Text = "Username:";
            // 
            // login_user_name_textBox1
            // 
            this.login_user_name_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_user_name_textBox1.Location = new System.Drawing.Point(51, 201);
            this.login_user_name_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_user_name_textBox1.Name = "login_user_name_textBox1";
            this.login_user_name_textBox1.Size = new System.Drawing.Size(407, 34);
            this.login_user_name_textBox1.TabIndex = 1;
            // 
            // register_tabPage2
            // 
            this.register_tabPage2.Controls.Add(this.register_head_label1);
            this.register_tabPage2.Controls.Add(this.rewiew_password_label1);
            this.register_tabPage2.Controls.Add(this.rewiew_password_textBox1);
            this.register_tabPage2.Controls.Add(this.register_button1);
            this.register_tabPage2.Controls.Add(this.first_name_label4);
            this.register_tabPage2.Controls.Add(this.first_name_textBox4);
            this.register_tabPage2.Controls.Add(this.last_name_label3);
            this.register_tabPage2.Controls.Add(this.last_name_textBox3);
            this.register_tabPage2.Controls.Add(this.reg_pass_label1);
            this.register_tabPage2.Controls.Add(this.register_password_textBox1);
            this.register_tabPage2.Controls.Add(this.reg_username_label2);
            this.register_tabPage2.Controls.Add(this.register_username_textBox2);
            this.register_tabPage2.Location = new System.Drawing.Point(4, 4);
            this.register_tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_tabPage2.Name = "register_tabPage2";
            this.register_tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_tabPage2.Size = new System.Drawing.Size(597, 615);
            this.register_tabPage2.TabIndex = 1;
            this.register_tabPage2.Text = "Register";
            this.register_tabPage2.UseVisualStyleBackColor = true;
            // 
            // register_head_label1
            // 
            this.register_head_label1.AutoSize = true;
            this.register_head_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_head_label1.Location = new System.Drawing.Point(48, 32);
            this.register_head_label1.Name = "register_head_label1";
            this.register_head_label1.Size = new System.Drawing.Size(455, 91);
            this.register_head_label1.TabIndex = 16;
            this.register_head_label1.Text = "REGISTER";
            this.register_head_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rewiew_password_label1
            // 
            this.rewiew_password_label1.AutoSize = true;
            this.rewiew_password_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewiew_password_label1.Location = new System.Drawing.Point(59, 439);
            this.rewiew_password_label1.Name = "rewiew_password_label1";
            this.rewiew_password_label1.Size = new System.Drawing.Size(219, 29);
            this.rewiew_password_label1.TabIndex = 15;
            this.rewiew_password_label1.Text = "Rewiew Password:";
            // 
            // rewiew_password_textBox1
            // 
            this.rewiew_password_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewiew_password_textBox1.Location = new System.Drawing.Point(64, 471);
            this.rewiew_password_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rewiew_password_textBox1.Name = "rewiew_password_textBox1";
            this.rewiew_password_textBox1.Size = new System.Drawing.Size(399, 34);
            this.rewiew_password_textBox1.TabIndex = 14;
            this.rewiew_password_textBox1.UseSystemPasswordChar = true;
            // 
            // register_button1
            // 
            this.register_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button1.Location = new System.Drawing.Point(167, 523);
            this.register_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_button1.Name = "register_button1";
            this.register_button1.Size = new System.Drawing.Size(213, 86);
            this.register_button1.TabIndex = 13;
            this.register_button1.Text = "Register";
            this.register_button1.UseVisualStyleBackColor = true;
            this.register_button1.Click += new System.EventHandler(this.register_button1_Click);
            // 
            // first_name_label4
            // 
            this.first_name_label4.AutoSize = true;
            this.first_name_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_label4.Location = new System.Drawing.Point(59, 162);
            this.first_name_label4.Name = "first_name_label4";
            this.first_name_label4.Size = new System.Drawing.Size(137, 29);
            this.first_name_label4.TabIndex = 12;
            this.first_name_label4.Text = "First Name:";
            // 
            // first_name_textBox4
            // 
            this.first_name_textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_textBox4.Location = new System.Drawing.Point(59, 194);
            this.first_name_textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.first_name_textBox4.Name = "first_name_textBox4";
            this.first_name_textBox4.Size = new System.Drawing.Size(399, 34);
            this.first_name_textBox4.TabIndex = 11;
            // 
            // last_name_label3
            // 
            this.last_name_label3.AutoSize = true;
            this.last_name_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_label3.Location = new System.Drawing.Point(55, 231);
            this.last_name_label3.Name = "last_name_label3";
            this.last_name_label3.Size = new System.Drawing.Size(134, 29);
            this.last_name_label3.TabIndex = 10;
            this.last_name_label3.Text = "Last Name:";
            // 
            // last_name_textBox3
            // 
            this.last_name_textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_textBox3.Location = new System.Drawing.Point(56, 263);
            this.last_name_textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.last_name_textBox3.Name = "last_name_textBox3";
            this.last_name_textBox3.Size = new System.Drawing.Size(399, 34);
            this.last_name_textBox3.TabIndex = 9;
            // 
            // reg_pass_label1
            // 
            this.reg_pass_label1.AutoSize = true;
            this.reg_pass_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pass_label1.Location = new System.Drawing.Point(59, 370);
            this.reg_pass_label1.Name = "reg_pass_label1";
            this.reg_pass_label1.Size = new System.Drawing.Size(126, 29);
            this.reg_pass_label1.TabIndex = 8;
            this.reg_pass_label1.Text = "Password:";
            // 
            // register_password_textBox1
            // 
            this.register_password_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password_textBox1.Location = new System.Drawing.Point(64, 402);
            this.register_password_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_password_textBox1.Name = "register_password_textBox1";
            this.register_password_textBox1.Size = new System.Drawing.Size(399, 34);
            this.register_password_textBox1.TabIndex = 7;
            this.register_password_textBox1.UseSystemPasswordChar = true;
            // 
            // reg_username_label2
            // 
            this.reg_username_label2.AutoSize = true;
            this.reg_username_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username_label2.Location = new System.Drawing.Point(59, 302);
            this.reg_username_label2.Name = "reg_username_label2";
            this.reg_username_label2.Size = new System.Drawing.Size(130, 29);
            this.reg_username_label2.TabIndex = 6;
            this.reg_username_label2.Text = "Username:";
            // 
            // register_username_textBox2
            // 
            this.register_username_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username_textBox2.Location = new System.Drawing.Point(59, 334);
            this.register_username_textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_username_textBox2.Name = "register_username_textBox2";
            this.register_username_textBox2.Size = new System.Drawing.Size(399, 34);
            this.register_username_textBox2.TabIndex = 5;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 645);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.login_tabPage1.ResumeLayout(false);
            this.login_tabPage1.PerformLayout();
            this.register_tabPage2.ResumeLayout(false);
            this.register_tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage login_tabPage1;
        private System.Windows.Forms.TabPage register_tabPage2;
        private System.Windows.Forms.Label password_label1;
        private System.Windows.Forms.TextBox login_password_textBox1;
        private System.Windows.Forms.Label username_label1;
        private System.Windows.Forms.TextBox login_user_name_textBox1;
        private System.Windows.Forms.Label first_name_label4;
        private System.Windows.Forms.TextBox first_name_textBox4;
        private System.Windows.Forms.Label last_name_label3;
        private System.Windows.Forms.TextBox last_name_textBox3;
        private System.Windows.Forms.Label reg_pass_label1;
        private System.Windows.Forms.TextBox register_password_textBox1;
        private System.Windows.Forms.Label reg_username_label2;
        private System.Windows.Forms.TextBox register_username_textBox2;
        private System.Windows.Forms.Label create_account_label1;
        private System.Windows.Forms.Button register_button1;
        private System.Windows.Forms.Label rewiew_password_label1;
        private System.Windows.Forms.TextBox rewiew_password_textBox1;
        private System.Windows.Forms.Label login_head_label1;
        private System.Windows.Forms.Label register_head_label1;
    }
}