namespace RealInstagram.Forms
{
    partial class Comment_Form
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
            this.comments_panel1 = new System.Windows.Forms.Panel();
            this.active_comment_panel1 = new System.Windows.Forms.Panel();
            this.post_id_label1 = new System.Windows.Forms.Label();
            this.active_comment_textBox1 = new System.Windows.Forms.TextBox();
            this.send_button1 = new System.Windows.Forms.Button();
            this.active_comment_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comments_panel1
            // 
            this.comments_panel1.AutoScroll = true;
            this.comments_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comments_panel1.Location = new System.Drawing.Point(0, 0);
            this.comments_panel1.Name = "comments_panel1";
            this.comments_panel1.Size = new System.Drawing.Size(460, 318);
            this.comments_panel1.TabIndex = 0;
            this.comments_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.comments_panel1_Paint);
            // 
            // active_comment_panel1
            // 
            this.active_comment_panel1.Controls.Add(this.post_id_label1);
            this.active_comment_panel1.Controls.Add(this.active_comment_textBox1);
            this.active_comment_panel1.Controls.Add(this.send_button1);
            this.active_comment_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.active_comment_panel1.Location = new System.Drawing.Point(0, 318);
            this.active_comment_panel1.Name = "active_comment_panel1";
            this.active_comment_panel1.Size = new System.Drawing.Size(460, 98);
            this.active_comment_panel1.TabIndex = 1;
            // 
            // post_id_label1
            // 
            this.post_id_label1.AutoSize = true;
            this.post_id_label1.Location = new System.Drawing.Point(31, 3);
            this.post_id_label1.Name = "post_id_label1";
            this.post_id_label1.Size = new System.Drawing.Size(11, 16);
            this.post_id_label1.TabIndex = 2;
            this.post_id_label1.Text = "-";
            // 
            // active_comment_textBox1
            // 
            this.active_comment_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_comment_textBox1.Location = new System.Drawing.Point(34, 31);
            this.active_comment_textBox1.Name = "active_comment_textBox1";
            this.active_comment_textBox1.Size = new System.Drawing.Size(297, 30);
            this.active_comment_textBox1.TabIndex = 1;
            // 
            // send_button1
            // 
            this.send_button1.Location = new System.Drawing.Point(354, 24);
            this.send_button1.Name = "send_button1";
            this.send_button1.Size = new System.Drawing.Size(94, 51);
            this.send_button1.TabIndex = 0;
            this.send_button1.Text = "Send";
            this.send_button1.UseVisualStyleBackColor = true;
            this.send_button1.Click += new System.EventHandler(this.send_button1_Click);
            // 
            // Comment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 416);
            this.Controls.Add(this.active_comment_panel1);
            this.Controls.Add(this.comments_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comment_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comment_Form";
            this.Load += new System.EventHandler(this.Comment_Form_Load);
            this.active_comment_panel1.ResumeLayout(false);
            this.active_comment_panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel comments_panel1;
        private System.Windows.Forms.Panel active_comment_panel1;
        private System.Windows.Forms.Button send_button1;
        private System.Windows.Forms.TextBox active_comment_textBox1;
        public System.Windows.Forms.Label post_id_label1;
    }
}