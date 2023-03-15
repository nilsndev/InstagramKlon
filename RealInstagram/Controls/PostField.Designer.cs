namespace RealInstagram.Controls
{
    partial class PostField
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.profile_panel1 = new System.Windows.Forms.Panel();
            this.delete_post_button1 = new System.Windows.Forms.Button();
            this.user_id_label1 = new System.Windows.Forms.Label();
            this.profile_name_label1 = new System.Windows.Forms.Label();
            this.profile_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.post_media_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.likeComment_area_panel1 = new System.Windows.Forms.Panel();
            this.like_count_label1 = new System.Windows.Forms.Label();
            this.caption_label1 = new System.Windows.Forms.Label();
            this.comment_button1 = new System.Windows.Forms.Button();
            this.like_button1 = new System.Windows.Forms.Button();
            this.post_id_label1 = new System.Windows.Forms.Label();
            this.profile_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_media_pictureBox1)).BeginInit();
            this.likeComment_area_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profile_panel1
            // 
            this.profile_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_panel1.Controls.Add(this.delete_post_button1);
            this.profile_panel1.Controls.Add(this.user_id_label1);
            this.profile_panel1.Controls.Add(this.profile_name_label1);
            this.profile_panel1.Controls.Add(this.profile_pictureBox1);
            this.profile_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_panel1.Location = new System.Drawing.Point(0, 0);
            this.profile_panel1.Name = "profile_panel1";
            this.profile_panel1.Size = new System.Drawing.Size(383, 88);
            this.profile_panel1.TabIndex = 0;
            this.profile_panel1.Click += new System.EventHandler(this.profile_panel1_Click);
            // 
            // delete_post_button1
            // 
            this.delete_post_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_post_button1.Location = new System.Drawing.Point(304, 3);
            this.delete_post_button1.Name = "delete_post_button1";
            this.delete_post_button1.Size = new System.Drawing.Size(75, 47);
            this.delete_post_button1.TabIndex = 4;
            this.delete_post_button1.Text = "Delete";
            this.delete_post_button1.UseVisualStyleBackColor = true;
            this.delete_post_button1.Visible = false;
            this.delete_post_button1.Click += new System.EventHandler(this.delete_post_button1_Click);
            // 
            // user_id_label1
            // 
            this.user_id_label1.AutoSize = true;
            this.user_id_label1.Location = new System.Drawing.Point(88, 46);
            this.user_id_label1.Name = "user_id_label1";
            this.user_id_label1.Size = new System.Drawing.Size(11, 16);
            this.user_id_label1.TabIndex = 4;
            this.user_id_label1.Text = "-";
            this.user_id_label1.Click += new System.EventHandler(this.profile_panel1_Click);
            // 
            // profile_name_label1
            // 
            this.profile_name_label1.Location = new System.Drawing.Point(83, 12);
            this.profile_name_label1.Name = "profile_name_label1";
            this.profile_name_label1.Size = new System.Drawing.Size(243, 23);
            this.profile_name_label1.TabIndex = 1;
            this.profile_name_label1.Text = "label1";
            this.profile_name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile_name_label1.Click += new System.EventHandler(this.profile_panel1_Click);
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
            this.profile_pictureBox1.Click += new System.EventHandler(this.profile_panel1_Click);
            // 
            // post_media_pictureBox1
            // 
            this.post_media_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.post_media_pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.post_media_pictureBox1.Location = new System.Drawing.Point(0, 88);
            this.post_media_pictureBox1.Name = "post_media_pictureBox1";
            this.post_media_pictureBox1.Size = new System.Drawing.Size(383, 369);
            this.post_media_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.post_media_pictureBox1.TabIndex = 1;
            this.post_media_pictureBox1.TabStop = false;
            this.post_media_pictureBox1.Click += new System.EventHandler(this.post_media_pictureBox1_Click);
            // 
            // likeComment_area_panel1
            // 
            this.likeComment_area_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.likeComment_area_panel1.Controls.Add(this.like_count_label1);
            this.likeComment_area_panel1.Controls.Add(this.caption_label1);
            this.likeComment_area_panel1.Controls.Add(this.comment_button1);
            this.likeComment_area_panel1.Controls.Add(this.like_button1);
            this.likeComment_area_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.likeComment_area_panel1.Location = new System.Drawing.Point(0, 338);
            this.likeComment_area_panel1.Name = "likeComment_area_panel1";
            this.likeComment_area_panel1.Size = new System.Drawing.Size(383, 119);
            this.likeComment_area_panel1.TabIndex = 2;
            this.likeComment_area_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.likeComment_area_panel1_Paint);
            // 
            // like_count_label1
            // 
            this.like_count_label1.AutoSize = true;
            this.like_count_label1.Location = new System.Drawing.Point(8, 52);
            this.like_count_label1.Name = "like_count_label1";
            this.like_count_label1.Size = new System.Drawing.Size(66, 16);
            this.like_count_label1.TabIndex = 5;
            this.like_count_label1.Text = "like 0 time";
            // 
            // caption_label1
            // 
            this.caption_label1.Location = new System.Drawing.Point(3, 75);
            this.caption_label1.Name = "caption_label1";
            this.caption_label1.Size = new System.Drawing.Size(375, 23);
            this.caption_label1.TabIndex = 4;
            this.caption_label1.Text = "-";
            this.caption_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caption_label1.Click += new System.EventHandler(this.caption_label1_Click);
            // 
            // comment_button1
            // 
            this.comment_button1.Location = new System.Drawing.Point(86, 3);
            this.comment_button1.Name = "comment_button1";
            this.comment_button1.Size = new System.Drawing.Size(102, 46);
            this.comment_button1.TabIndex = 3;
            this.comment_button1.Text = "Comment";
            this.comment_button1.UseVisualStyleBackColor = true;
            this.comment_button1.Click += new System.EventHandler(this.comment_button1_Click);
            // 
            // like_button1
            // 
            this.like_button1.Location = new System.Drawing.Point(3, 3);
            this.like_button1.Name = "like_button1";
            this.like_button1.Size = new System.Drawing.Size(71, 46);
            this.like_button1.TabIndex = 0;
            this.like_button1.Text = "Like";
            this.like_button1.UseVisualStyleBackColor = true;
            this.like_button1.Click += new System.EventHandler(this.like_button1_Click);
            // 
            // post_id_label1
            // 
            this.post_id_label1.AutoSize = true;
            this.post_id_label1.Location = new System.Drawing.Point(25, 118);
            this.post_id_label1.Name = "post_id_label1";
            this.post_id_label1.Size = new System.Drawing.Size(11, 16);
            this.post_id_label1.TabIndex = 3;
            this.post_id_label1.Text = "-";
            // 
            // PostField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.post_id_label1);
            this.Controls.Add(this.likeComment_area_panel1);
            this.Controls.Add(this.post_media_pictureBox1);
            this.Controls.Add(this.profile_panel1);
            this.Name = "PostField";
            this.Size = new System.Drawing.Size(383, 457);
            this.Load += new System.EventHandler(this.PostField_Load);
            this.profile_panel1.ResumeLayout(false);
            this.profile_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_media_pictureBox1)).EndInit();
            this.likeComment_area_panel1.ResumeLayout(false);
            this.likeComment_area_panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel profile_panel1;
        private System.Windows.Forms.Panel likeComment_area_panel1;
        private System.Windows.Forms.Button like_button1;
        private System.Windows.Forms.Button comment_button1;
        public System.Windows.Forms.PictureBox profile_pictureBox1;
        public System.Windows.Forms.Label profile_name_label1;
        public System.Windows.Forms.PictureBox post_media_pictureBox1;
        public System.Windows.Forms.Label caption_label1;
        public System.Windows.Forms.Label post_id_label1;
        public System.Windows.Forms.Label user_id_label1;
        private System.Windows.Forms.Label like_count_label1;
        private System.Windows.Forms.Button delete_post_button1;
    }
}
