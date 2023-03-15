namespace RealInstagram.Controls
{
    partial class SearchUserField
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
            this.user_name_value_label1 = new System.Windows.Forms.Label();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_id_label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name_value_label1
            // 
            this.user_name_value_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_value_label1.Location = new System.Drawing.Point(166, 23);
            this.user_name_value_label1.Name = "user_name_value_label1";
            this.user_name_value_label1.Size = new System.Drawing.Size(297, 38);
            this.user_name_value_label1.TabIndex = 2;
            this.user_name_value_label1.Text = "-";
            this.user_name_value_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_name_value_label1.Click += new System.EventHandler(this.SearchUserField_Click);
            // 
            // user_pictureBox1
            // 
            this.user_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(113, 96);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pictureBox1.TabIndex = 0;
            this.user_pictureBox1.TabStop = false;
            this.user_pictureBox1.Click += new System.EventHandler(this.SearchUserField_Click);
            // 
            // user_id_label2
            // 
            this.user_id_label2.AutoSize = true;
            this.user_id_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id_label2.Location = new System.Drawing.Point(166, 99);
            this.user_id_label2.Name = "user_id_label2";
            this.user_id_label2.Size = new System.Drawing.Size(15, 20);
            this.user_id_label2.TabIndex = 3;
            this.user_id_label2.Text = "-";
            this.user_id_label2.Click += new System.EventHandler(this.SearchUserField_Click);
            // 
            // SearchUserField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.user_id_label2);
            this.Controls.Add(this.user_name_value_label1);
            this.Controls.Add(this.user_pictureBox1);
            this.Name = "SearchUserField";
            this.Size = new System.Drawing.Size(521, 150);
            this.Load += new System.EventHandler(this.SearchUserField_Load);
            this.Click += new System.EventHandler(this.SearchUserField_Click);
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label user_id_label2;
        public System.Windows.Forms.PictureBox user_pictureBox1;
        public System.Windows.Forms.Label user_name_value_label1;
    }
}
