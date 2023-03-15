namespace RealInstagram.Forms
{
    partial class viewPostForm
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
            this.profile_panel1 = new System.Windows.Forms.Panel();
            this.delet_button1 = new System.Windows.Forms.Button();
            this.profile_name_label1 = new System.Windows.Forms.Label();
            this.profile_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.post_id_label1 = new System.Windows.Forms.Label();
            this.likeComment_area_panel1 = new System.Windows.Forms.Panel();
            this.like_count_label1 = new System.Windows.Forms.Label();
            this.caption_label1 = new System.Windows.Forms.Label();
            this.comment_button1 = new System.Windows.Forms.Button();
            this.like_button1 = new System.Windows.Forms.Button();
            this.post_media_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profile_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox1)).BeginInit();
            this.likeComment_area_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_media_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // profile_panel1
            // 
            this.profile_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_panel1.Controls.Add(this.delet_button1);
            this.profile_panel1.Controls.Add(this.profile_name_label1);
            this.profile_panel1.Controls.Add(this.profile_pictureBox1);
            this.profile_panel1.Controls.Add(this.post_id_label1);
            this.profile_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_panel1.Location = new System.Drawing.Point(0, 0);
            this.profile_panel1.Name = "profile_panel1";
            this.profile_panel1.Size = new System.Drawing.Size(585, 88);
            this.profile_panel1.TabIndex = 4;
            // 
            // delet_button1
            // 
            this.delet_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delet_button1.Location = new System.Drawing.Point(484, 12);
            this.delet_button1.Name = "delet_button1";
            this.delet_button1.Size = new System.Drawing.Size(88, 37);
            this.delet_button1.TabIndex = 8;
            this.delet_button1.Text = "Delete";
            this.delet_button1.UseVisualStyleBackColor = true;
            this.delet_button1.Visible = false;
            this.delet_button1.Click += new System.EventHandler(this.delet_button1_Click);
            // 
            // profile_name_label1
            // 
            this.profile_name_label1.Location = new System.Drawing.Point(83, 12);
            this.profile_name_label1.Name = "profile_name_label1";
            this.profile_name_label1.Size = new System.Drawing.Size(243, 23);
            this.profile_name_label1.TabIndex = 1;
            this.profile_name_label1.Text = "label1";
            this.profile_name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profile_pictureBox1
            // 
            this.profile_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.profile_pictureBox1.Name = "profile_pictureBox1";
            this.profile_pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.profile_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pictureBox1.TabIndex = 0;
            this.profile_pictureBox1.TabStop = false;
            // 
            // post_id_label1
            // 
            this.post_id_label1.AutoSize = true;
            this.post_id_label1.Location = new System.Drawing.Point(83, 46);
            this.post_id_label1.Name = "post_id_label1";
            this.post_id_label1.Size = new System.Drawing.Size(11, 16);
            this.post_id_label1.TabIndex = 7;
            this.post_id_label1.Text = "-";
            // 
            // likeComment_area_panel1
            // 
            this.likeComment_area_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.likeComment_area_panel1.Controls.Add(this.like_count_label1);
            this.likeComment_area_panel1.Controls.Add(this.caption_label1);
            this.likeComment_area_panel1.Controls.Add(this.comment_button1);
            this.likeComment_area_panel1.Controls.Add(this.like_button1);
            this.likeComment_area_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.likeComment_area_panel1.Location = new System.Drawing.Point(0, 464);
            this.likeComment_area_panel1.Name = "likeComment_area_panel1";
            this.likeComment_area_panel1.Size = new System.Drawing.Size(585, 102);
            this.likeComment_area_panel1.TabIndex = 6;
            this.likeComment_area_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.likeComment_area_panel1_Paint);
            // 
            // like_count_label1
            // 
            this.like_count_label1.AutoSize = true;
            this.like_count_label1.Location = new System.Drawing.Point(14, 45);
            this.like_count_label1.Name = "like_count_label1";
            this.like_count_label1.Size = new System.Drawing.Size(66, 16);
            this.like_count_label1.TabIndex = 6;
            this.like_count_label1.Text = "like 0 time";
            // 
            // caption_label1
            // 
            this.caption_label1.Location = new System.Drawing.Point(14, 69);
            this.caption_label1.Name = "caption_label1";
            this.caption_label1.Size = new System.Drawing.Size(569, 23);
            this.caption_label1.TabIndex = 4;
            this.caption_label1.Text = "-";
            this.caption_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caption_label1.Click += new System.EventHandler(this.caption_label1_Click);
            // 
            // comment_button1
            // 
            this.comment_button1.Location = new System.Drawing.Point(113, 3);
            this.comment_button1.Name = "comment_button1";
            this.comment_button1.Size = new System.Drawing.Size(109, 40);
            this.comment_button1.TabIndex = 3;
            this.comment_button1.Text = "Comment";
            this.comment_button1.UseVisualStyleBackColor = true;
            this.comment_button1.Click += new System.EventHandler(this.comment_button1_Click);
            // 
            // like_button1
            // 
            this.like_button1.Location = new System.Drawing.Point(11, 2);
            this.like_button1.Name = "like_button1";
            this.like_button1.Size = new System.Drawing.Size(96, 40);
            this.like_button1.TabIndex = 0;
            this.like_button1.Text = "Like";
            this.like_button1.UseVisualStyleBackColor = true;
            this.like_button1.Click += new System.EventHandler(this.like_button1_Click);
            // 
            // post_media_pictureBox1
            // 
            this.post_media_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.post_media_pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.post_media_pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.post_media_pictureBox1.Name = "post_media_pictureBox1";
            this.post_media_pictureBox1.Size = new System.Drawing.Size(585, 566);
            this.post_media_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.post_media_pictureBox1.TabIndex = 5;
            this.post_media_pictureBox1.TabStop = false;
            // 
            // viewPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 566);
            this.Controls.Add(this.profile_panel1);
            this.Controls.Add(this.likeComment_area_panel1);
            this.Controls.Add(this.post_media_pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewPostForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Post";
            this.Load += new System.EventHandler(this.viewPostForm_Load);
            this.profile_panel1.ResumeLayout(false);
            this.profile_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox1)).EndInit();
            this.likeComment_area_panel1.ResumeLayout(false);
            this.likeComment_area_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_media_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel profile_panel1;
        public System.Windows.Forms.Label profile_name_label1;
        public System.Windows.Forms.PictureBox profile_pictureBox1;
        private System.Windows.Forms.Panel likeComment_area_panel1;
        public System.Windows.Forms.Label caption_label1;
        private System.Windows.Forms.Button comment_button1;
        private System.Windows.Forms.Button like_button1;
        public System.Windows.Forms.PictureBox post_media_pictureBox1;
        public System.Windows.Forms.Label post_id_label1;
        private System.Windows.Forms.Label like_count_label1;
        private System.Windows.Forms.Button delet_button1;
    }
}