namespace RealInstagram.Forms
{
    partial class Edit_User_Form
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
            this.user_name_textBox1 = new System.Windows.Forms.TextBox();
            this.user_name_label1 = new System.Windows.Forms.Label();
            this.user_password_label1 = new System.Windows.Forms.Label();
            this.user_pass_textBox1 = new System.Windows.Forms.TextBox();
            this.submit_changes_button1 = new System.Windows.Forms.Button();
            this.select_image_button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.user_image_pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_image_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name_textBox1
            // 
            this.user_name_textBox1.Location = new System.Drawing.Point(85, 223);
            this.user_name_textBox1.Name = "user_name_textBox1";
            this.user_name_textBox1.Size = new System.Drawing.Size(233, 22);
            this.user_name_textBox1.TabIndex = 0;
            // 
            // user_name_label1
            // 
            this.user_name_label1.AutoSize = true;
            this.user_name_label1.Location = new System.Drawing.Point(82, 195);
            this.user_name_label1.Name = "user_name_label1";
            this.user_name_label1.Size = new System.Drawing.Size(79, 16);
            this.user_name_label1.TabIndex = 1;
            this.user_name_label1.Text = "User Name:";
            // 
            // user_password_label1
            // 
            this.user_password_label1.AutoSize = true;
            this.user_password_label1.Location = new System.Drawing.Point(82, 269);
            this.user_password_label1.Name = "user_password_label1";
            this.user_password_label1.Size = new System.Drawing.Size(102, 16);
            this.user_password_label1.TabIndex = 3;
            this.user_password_label1.Text = "User Password:";
            // 
            // user_pass_textBox1
            // 
            this.user_pass_textBox1.Location = new System.Drawing.Point(85, 299);
            this.user_pass_textBox1.Name = "user_pass_textBox1";
            this.user_pass_textBox1.Size = new System.Drawing.Size(233, 22);
            this.user_pass_textBox1.TabIndex = 2;
            // 
            // submit_changes_button1
            // 
            this.submit_changes_button1.Location = new System.Drawing.Point(109, 342);
            this.submit_changes_button1.Name = "submit_changes_button1";
            this.submit_changes_button1.Size = new System.Drawing.Size(172, 64);
            this.submit_changes_button1.TabIndex = 4;
            this.submit_changes_button1.Text = "Submit Changes";
            this.submit_changes_button1.UseVisualStyleBackColor = true;
            this.submit_changes_button1.Click += new System.EventHandler(this.submit_changes_button1_Click);
            // 
            // select_image_button1
            // 
            this.select_image_button1.Location = new System.Drawing.Point(136, 145);
            this.select_image_button1.Name = "select_image_button1";
            this.select_image_button1.Size = new System.Drawing.Size(109, 32);
            this.select_image_button1.TabIndex = 6;
            this.select_image_button1.Text = "Select Image";
            this.select_image_button1.UseVisualStyleBackColor = true;
            this.select_image_button1.Click += new System.EventHandler(this.select_image_button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // user_image_pictureBox1
            // 
            this.user_image_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.user_image_pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.user_image_pictureBox1.Name = "user_image_pictureBox1";
            this.user_image_pictureBox1.Size = new System.Drawing.Size(109, 106);
            this.user_image_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_image_pictureBox1.TabIndex = 5;
            this.user_image_pictureBox1.TabStop = false;
            // 
            // Edit_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 428);
            this.Controls.Add(this.select_image_button1);
            this.Controls.Add(this.user_image_pictureBox1);
            this.Controls.Add(this.submit_changes_button1);
            this.Controls.Add(this.user_password_label1);
            this.Controls.Add(this.user_pass_textBox1);
            this.Controls.Add(this.user_name_label1);
            this.Controls.Add(this.user_name_textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_User_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.Edit_User_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_image_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user_name_label1;
        private System.Windows.Forms.Label user_password_label1;
        private System.Windows.Forms.Button submit_changes_button1;
        private System.Windows.Forms.Button select_image_button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox user_name_textBox1;
        public System.Windows.Forms.TextBox user_pass_textBox1;
        public System.Windows.Forms.PictureBox user_image_pictureBox1;
    }
}