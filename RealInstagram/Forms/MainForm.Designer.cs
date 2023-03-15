namespace RealInstagram.Forms
{
    partial class MainForm
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
            this.instagram_tabControl1 = new System.Windows.Forms.TabControl();
            this.posts_tabPage1 = new System.Windows.Forms.TabPage();
            this.profile_tabPage2 = new System.Windows.Forms.TabPage();
            this.edit_profile_button1 = new System.Windows.Forms.Button();
            this.following_value_label1 = new System.Windows.Forms.Label();
            this.followers_value_label1 = new System.Windows.Forms.Label();
            this.posts_count_value_label1 = new System.Windows.Forms.Label();
            this.following_name_label2 = new System.Windows.Forms.Label();
            this.followers_name_label1 = new System.Windows.Forms.Label();
            this.posts_name_label1 = new System.Windows.Forms.Label();
            this.addPost_button1 = new System.Windows.Forms.Button();
            this.posts_panel1 = new System.Windows.Forms.Panel();
            this.anzeige_name_label1 = new System.Windows.Forms.Label();
            this.profile_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_tabPage1 = new System.Windows.Forms.TabPage();
            this.searched_user_panel1 = new System.Windows.Forms.Panel();
            this.search_button1 = new System.Windows.Forms.Button();
            this.search_label1 = new System.Windows.Forms.Label();
            this.search_textBox1 = new System.Windows.Forms.TextBox();
            this.logout_button1 = new System.Windows.Forms.Button();
            this.instagram_tabControl1.SuspendLayout();
            this.profile_tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox1)).BeginInit();
            this.search_tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // instagram_tabControl1
            // 
            this.instagram_tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.instagram_tabControl1.Controls.Add(this.posts_tabPage1);
            this.instagram_tabControl1.Controls.Add(this.profile_tabPage2);
            this.instagram_tabControl1.Controls.Add(this.search_tabPage1);
            this.instagram_tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instagram_tabControl1.Location = new System.Drawing.Point(0, 0);
            this.instagram_tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instagram_tabControl1.Name = "instagram_tabControl1";
            this.instagram_tabControl1.SelectedIndex = 0;
            this.instagram_tabControl1.Size = new System.Drawing.Size(787, 646);
            this.instagram_tabControl1.TabIndex = 0;
            // 
            // posts_tabPage1
            // 
            this.posts_tabPage1.AutoScroll = true;
            this.posts_tabPage1.Location = new System.Drawing.Point(4, 4);
            this.posts_tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.posts_tabPage1.Name = "posts_tabPage1";
            this.posts_tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.posts_tabPage1.Size = new System.Drawing.Size(779, 617);
            this.posts_tabPage1.TabIndex = 0;
            this.posts_tabPage1.Text = "Posts";
            this.posts_tabPage1.UseVisualStyleBackColor = true;
            this.posts_tabPage1.Click += new System.EventHandler(this.posts_tabPage1_Click);
            this.posts_tabPage1.Enter += new System.EventHandler(this.posts_tabPage1_Enter);
            // 
            // profile_tabPage2
            // 
            this.profile_tabPage2.Controls.Add(this.logout_button1);
            this.profile_tabPage2.Controls.Add(this.edit_profile_button1);
            this.profile_tabPage2.Controls.Add(this.following_value_label1);
            this.profile_tabPage2.Controls.Add(this.followers_value_label1);
            this.profile_tabPage2.Controls.Add(this.posts_count_value_label1);
            this.profile_tabPage2.Controls.Add(this.following_name_label2);
            this.profile_tabPage2.Controls.Add(this.followers_name_label1);
            this.profile_tabPage2.Controls.Add(this.posts_name_label1);
            this.profile_tabPage2.Controls.Add(this.addPost_button1);
            this.profile_tabPage2.Controls.Add(this.posts_panel1);
            this.profile_tabPage2.Controls.Add(this.anzeige_name_label1);
            this.profile_tabPage2.Controls.Add(this.profile_pictureBox1);
            this.profile_tabPage2.Location = new System.Drawing.Point(4, 4);
            this.profile_tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile_tabPage2.Name = "profile_tabPage2";
            this.profile_tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile_tabPage2.Size = new System.Drawing.Size(779, 617);
            this.profile_tabPage2.TabIndex = 1;
            this.profile_tabPage2.Text = "Profile";
            this.profile_tabPage2.UseVisualStyleBackColor = true;
            this.profile_tabPage2.Click += new System.EventHandler(this.profile_tabPage2_Click);
            this.profile_tabPage2.Enter += new System.EventHandler(this.profile_tabPage2_Enter);
            // 
            // edit_profile_button1
            // 
            this.edit_profile_button1.Location = new System.Drawing.Point(191, 256);
            this.edit_profile_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_profile_button1.Name = "edit_profile_button1";
            this.edit_profile_button1.Size = new System.Drawing.Size(131, 62);
            this.edit_profile_button1.TabIndex = 11;
            this.edit_profile_button1.Text = "Edit User";
            this.edit_profile_button1.UseVisualStyleBackColor = true;
            this.edit_profile_button1.Click += new System.EventHandler(this.edit_profile_button1_Click);
            // 
            // following_value_label1
            // 
            this.following_value_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.following_value_label1.Location = new System.Drawing.Point(421, 122);
            this.following_value_label1.Name = "following_value_label1";
            this.following_value_label1.Size = new System.Drawing.Size(100, 23);
            this.following_value_label1.TabIndex = 10;
            this.following_value_label1.Text = "0";
            this.following_value_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // followers_value_label1
            // 
            this.followers_value_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followers_value_label1.Location = new System.Drawing.Point(307, 122);
            this.followers_value_label1.Name = "followers_value_label1";
            this.followers_value_label1.Size = new System.Drawing.Size(100, 23);
            this.followers_value_label1.TabIndex = 9;
            this.followers_value_label1.Text = "0";
            this.followers_value_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posts_count_value_label1
            // 
            this.posts_count_value_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posts_count_value_label1.Location = new System.Drawing.Point(201, 122);
            this.posts_count_value_label1.Name = "posts_count_value_label1";
            this.posts_count_value_label1.Size = new System.Drawing.Size(100, 23);
            this.posts_count_value_label1.TabIndex = 8;
            this.posts_count_value_label1.Text = "0";
            this.posts_count_value_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // following_name_label2
            // 
            this.following_name_label2.Location = new System.Drawing.Point(423, 145);
            this.following_name_label2.Name = "following_name_label2";
            this.following_name_label2.Size = new System.Drawing.Size(99, 38);
            this.following_name_label2.TabIndex = 7;
            this.following_name_label2.Text = "followng";
            this.following_name_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // followers_name_label1
            // 
            this.followers_name_label1.Location = new System.Drawing.Point(307, 145);
            this.followers_name_label1.Name = "followers_name_label1";
            this.followers_name_label1.Size = new System.Drawing.Size(99, 38);
            this.followers_name_label1.TabIndex = 6;
            this.followers_name_label1.Text = "followers";
            this.followers_name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posts_name_label1
            // 
            this.posts_name_label1.Location = new System.Drawing.Point(203, 145);
            this.posts_name_label1.Name = "posts_name_label1";
            this.posts_name_label1.Size = new System.Drawing.Size(99, 38);
            this.posts_name_label1.TabIndex = 5;
            this.posts_name_label1.Text = "posts";
            this.posts_name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addPost_button1
            // 
            this.addPost_button1.Location = new System.Drawing.Point(45, 256);
            this.addPost_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPost_button1.Name = "addPost_button1";
            this.addPost_button1.Size = new System.Drawing.Size(131, 62);
            this.addPost_button1.TabIndex = 4;
            this.addPost_button1.Text = "Add Post";
            this.addPost_button1.UseVisualStyleBackColor = true;
            this.addPost_button1.Click += new System.EventHandler(this.addPost_button1_Click);
            // 
            // posts_panel1
            // 
            this.posts_panel1.AutoScroll = true;
            this.posts_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posts_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.posts_panel1.Location = new System.Drawing.Point(3, 329);
            this.posts_panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.posts_panel1.Name = "posts_panel1";
            this.posts_panel1.Size = new System.Drawing.Size(773, 286);
            this.posts_panel1.TabIndex = 3;
            // 
            // anzeige_name_label1
            // 
            this.anzeige_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anzeige_name_label1.Location = new System.Drawing.Point(224, 33);
            this.anzeige_name_label1.Name = "anzeige_name_label1";
            this.anzeige_name_label1.Size = new System.Drawing.Size(549, 48);
            this.anzeige_name_label1.TabIndex = 1;
            this.anzeige_name_label1.Text = "-";
            this.anzeige_name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profile_pictureBox1
            // 
            this.profile_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_pictureBox1.Location = new System.Drawing.Point(45, 33);
            this.profile_pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile_pictureBox1.Name = "profile_pictureBox1";
            this.profile_pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.profile_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pictureBox1.TabIndex = 0;
            this.profile_pictureBox1.TabStop = false;
            // 
            // search_tabPage1
            // 
            this.search_tabPage1.Controls.Add(this.searched_user_panel1);
            this.search_tabPage1.Controls.Add(this.search_button1);
            this.search_tabPage1.Controls.Add(this.search_label1);
            this.search_tabPage1.Controls.Add(this.search_textBox1);
            this.search_tabPage1.Location = new System.Drawing.Point(4, 4);
            this.search_tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_tabPage1.Name = "search_tabPage1";
            this.search_tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_tabPage1.Size = new System.Drawing.Size(779, 617);
            this.search_tabPage1.TabIndex = 2;
            this.search_tabPage1.Text = "Search";
            this.search_tabPage1.UseVisualStyleBackColor = true;
            // 
            // searched_user_panel1
            // 
            this.searched_user_panel1.AutoScroll = true;
            this.searched_user_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searched_user_panel1.Location = new System.Drawing.Point(3, 105);
            this.searched_user_panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searched_user_panel1.Name = "searched_user_panel1";
            this.searched_user_panel1.Size = new System.Drawing.Size(773, 510);
            this.searched_user_panel1.TabIndex = 3;
            // 
            // search_button1
            // 
            this.search_button1.Location = new System.Drawing.Point(453, 30);
            this.search_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_button1.Name = "search_button1";
            this.search_button1.Size = new System.Drawing.Size(97, 48);
            this.search_button1.TabIndex = 2;
            this.search_button1.Text = "Search";
            this.search_button1.UseVisualStyleBackColor = true;
            this.search_button1.Click += new System.EventHandler(this.search_button1_Click);
            // 
            // search_label1
            // 
            this.search_label1.Location = new System.Drawing.Point(43, 30);
            this.search_label1.Name = "search_label1";
            this.search_label1.Size = new System.Drawing.Size(303, 23);
            this.search_label1.TabIndex = 1;
            this.search_label1.Text = "Search:";
            // 
            // search_textBox1
            // 
            this.search_textBox1.Location = new System.Drawing.Point(45, 57);
            this.search_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_textBox1.Name = "search_textBox1";
            this.search_textBox1.Size = new System.Drawing.Size(300, 22);
            this.search_textBox1.TabIndex = 0;
            // 
            // logout_button1
            // 
            this.logout_button1.Location = new System.Drawing.Point(643, 24);
            this.logout_button1.Name = "logout_button1";
            this.logout_button1.Size = new System.Drawing.Size(96, 47);
            this.logout_button1.TabIndex = 12;
            this.logout_button1.Text = "LogOut";
            this.logout_button1.UseVisualStyleBackColor = true;
            this.logout_button1.Click += new System.EventHandler(this.logout_button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 646);
            this.Controls.Add(this.instagram_tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Instagram";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.instagram_tabControl1.ResumeLayout(false);
            this.profile_tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox1)).EndInit();
            this.search_tabPage1.ResumeLayout(false);
            this.search_tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl instagram_tabControl1;
        private System.Windows.Forms.TabPage posts_tabPage1;
        private System.Windows.Forms.TabPage profile_tabPage2;
        private System.Windows.Forms.TabPage search_tabPage1;
        private System.Windows.Forms.PictureBox profile_pictureBox1;
        private System.Windows.Forms.Label anzeige_name_label1;
        private System.Windows.Forms.Panel posts_panel1;
        private System.Windows.Forms.Button addPost_button1;
        private System.Windows.Forms.Label posts_name_label1;
        private System.Windows.Forms.Label following_name_label2;
        private System.Windows.Forms.Label followers_name_label1;
        private System.Windows.Forms.Label posts_count_value_label1;
        private System.Windows.Forms.Label followers_value_label1;
        private System.Windows.Forms.Label following_value_label1;
        private System.Windows.Forms.Button edit_profile_button1;
        private System.Windows.Forms.TextBox search_textBox1;
        private System.Windows.Forms.Label search_label1;
        private System.Windows.Forms.Button search_button1;
        private System.Windows.Forms.Panel searched_user_panel1;
        private System.Windows.Forms.Button logout_button1;
    }
}