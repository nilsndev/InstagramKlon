namespace RealInstagram.Forms
{
    partial class NewPostForm
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
            this.post_img_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.select_img_button1 = new System.Windows.Forms.Button();
            this.caption_label1 = new System.Windows.Forms.Label();
            this.caption_textBox1 = new System.Windows.Forms.TextBox();
            this.select_post_comboBox1 = new System.Windows.Forms.ComboBox();
            this.select_post_label1 = new System.Windows.Forms.Label();
            this.submit_button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.post_img_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // post_img_pictureBox1
            // 
            this.post_img_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.post_img_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.post_img_pictureBox1.Location = new System.Drawing.Point(53, 44);
            this.post_img_pictureBox1.Name = "post_img_pictureBox1";
            this.post_img_pictureBox1.Size = new System.Drawing.Size(132, 121);
            this.post_img_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.post_img_pictureBox1.TabIndex = 0;
            this.post_img_pictureBox1.TabStop = false;
            // 
            // select_img_button1
            // 
            this.select_img_button1.Location = new System.Drawing.Point(43, 180);
            this.select_img_button1.Name = "select_img_button1";
            this.select_img_button1.Size = new System.Drawing.Size(146, 42);
            this.select_img_button1.TabIndex = 1;
            this.select_img_button1.Text = "Select Image";
            this.select_img_button1.UseVisualStyleBackColor = true;
            this.select_img_button1.Click += new System.EventHandler(this.select_img_button1_Click);
            // 
            // caption_label1
            // 
            this.caption_label1.AutoSize = true;
            this.caption_label1.Location = new System.Drawing.Point(297, 44);
            this.caption_label1.Name = "caption_label1";
            this.caption_label1.Size = new System.Drawing.Size(56, 16);
            this.caption_label1.TabIndex = 2;
            this.caption_label1.Text = "Caption:";
            // 
            // caption_textBox1
            // 
            this.caption_textBox1.Location = new System.Drawing.Point(300, 63);
            this.caption_textBox1.Multiline = true;
            this.caption_textBox1.Name = "caption_textBox1";
            this.caption_textBox1.Size = new System.Drawing.Size(402, 159);
            this.caption_textBox1.TabIndex = 3;
            // 
            // select_post_comboBox1
            // 
            this.select_post_comboBox1.Enabled = false;
            this.select_post_comboBox1.FormattingEnabled = true;
            this.select_post_comboBox1.Location = new System.Drawing.Point(43, 279);
            this.select_post_comboBox1.Name = "select_post_comboBox1";
            this.select_post_comboBox1.Size = new System.Drawing.Size(146, 24);
            this.select_post_comboBox1.TabIndex = 4;
            // 
            // select_post_label1
            // 
            this.select_post_label1.AutoSize = true;
            this.select_post_label1.Enabled = false;
            this.select_post_label1.Location = new System.Drawing.Point(40, 260);
            this.select_post_label1.Name = "select_post_label1";
            this.select_post_label1.Size = new System.Drawing.Size(121, 16);
            this.select_post_label1.TabIndex = 5;
            this.select_post_label1.Text = "Select a Post Type";
            // 
            // submit_button1
            // 
            this.submit_button1.Location = new System.Drawing.Point(384, 327);
            this.submit_button1.Name = "submit_button1";
            this.submit_button1.Size = new System.Drawing.Size(214, 73);
            this.submit_button1.TabIndex = 6;
            this.submit_button1.Text = "Submit";
            this.submit_button1.UseVisualStyleBackColor = true;
            this.submit_button1.Click += new System.EventHandler(this.submit_button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 463);
            this.Controls.Add(this.submit_button1);
            this.Controls.Add(this.select_post_label1);
            this.Controls.Add(this.select_post_comboBox1);
            this.Controls.Add(this.caption_textBox1);
            this.Controls.Add(this.caption_label1);
            this.Controls.Add(this.select_img_button1);
            this.Controls.Add(this.post_img_pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPostForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Post";
            this.Load += new System.EventHandler(this.NewPostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.post_img_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox post_img_pictureBox1;
        private System.Windows.Forms.Button select_img_button1;
        private System.Windows.Forms.Label caption_label1;
        private System.Windows.Forms.TextBox caption_textBox1;
        private System.Windows.Forms.ComboBox select_post_comboBox1;
        private System.Windows.Forms.Label select_post_label1;
        private System.Windows.Forms.Button submit_button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}