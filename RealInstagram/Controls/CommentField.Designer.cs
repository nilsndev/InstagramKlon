namespace RealInstagram.Controls
{
    partial class CommentField
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
            this.user_img_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comment_text_label1 = new System.Windows.Forms.Label();
            this.user_id_label1 = new System.Windows.Forms.Label();
            this.delete_button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_img_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_img_pictureBox1
            // 
            this.user_img_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_img_pictureBox1.Location = new System.Drawing.Point(20, 6);
            this.user_img_pictureBox1.Name = "user_img_pictureBox1";
            this.user_img_pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.user_img_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_img_pictureBox1.TabIndex = 0;
            this.user_img_pictureBox1.TabStop = false;
            // 
            // comment_text_label1
            // 
            this.comment_text_label1.Location = new System.Drawing.Point(66, 6);
            this.comment_text_label1.Name = "comment_text_label1";
            this.comment_text_label1.Size = new System.Drawing.Size(311, 62);
            this.comment_text_label1.TabIndex = 2;
            this.comment_text_label1.Text = "-";
            // 
            // user_id_label1
            // 
            this.user_id_label1.AutoSize = true;
            this.user_id_label1.Location = new System.Drawing.Point(32, 60);
            this.user_id_label1.Name = "user_id_label1";
            this.user_id_label1.Size = new System.Drawing.Size(11, 16);
            this.user_id_label1.TabIndex = 3;
            this.user_id_label1.Text = "-";
            // 
            // delete_button1
            // 
            this.delete_button1.Location = new System.Drawing.Point(379, 6);
            this.delete_button1.Name = "delete_button1";
            this.delete_button1.Size = new System.Drawing.Size(75, 23);
            this.delete_button1.TabIndex = 4;
            this.delete_button1.Text = "Delete";
            this.delete_button1.UseVisualStyleBackColor = true;
            this.delete_button1.Visible = false;
            // 
            // CommentField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.delete_button1);
            this.Controls.Add(this.user_id_label1);
            this.Controls.Add(this.comment_text_label1);
            this.Controls.Add(this.user_img_pictureBox1);
            this.Name = "CommentField";
            this.Size = new System.Drawing.Size(453, 80);
            this.Load += new System.EventHandler(this.CommentField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_img_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox user_img_pictureBox1;
        public System.Windows.Forms.Label comment_text_label1;
        public System.Windows.Forms.Label user_id_label1;
        private System.Windows.Forms.Button delete_button1;
    }
}
