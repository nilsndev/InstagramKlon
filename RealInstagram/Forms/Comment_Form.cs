using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealInstagram.Class;
using RealInstagram.Controls;
using RealInstagram.Properties;

namespace RealInstagram.Forms
{
    public partial class Comment_Form : Form
    {
        public Comment_Form()
        {
            InitializeComponent();
        }
        private void send_button1_Click(object sender, EventArgs e){
            if(this.active_comment_textBox1.Text == ""){
                MessageBox.Show("The Comment Text can't be empty");
                return;
            }
            int user_id = Settings.Default.activeUserID;
            int post_id = Convert.ToInt32(this.post_id_label1.Text);
            Comment comment = new Comment();
            comment.Comment_text = this.active_comment_textBox1.Text;
            comment.InsertData(user_id, post_id);
            loadAllComments();
            this.active_comment_textBox1.ResetText();
        }
        void loadAllComments(){
            Comment[] commentArr = (new Comment()).GetValuesFromClass("post_id = " + this.post_id_label1.Text);
            if (commentArr.Count() == 0){
                return;
            }
            for(int i  = 0; i< commentArr.Count(); i++){
                CommentField cf = new CommentField();
                cf.comment_text_label1.Text = commentArr[i].Comment_text;
                cf.user_id_label1.Text = commentArr[i].Created_by_user_id.ToString();
                cf.Location = new Point(0, cf.Height * i);
                this.comments_panel1.Controls.Add(cf);
            }
        }

        private void comments_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Comment_Form_Load(object sender, EventArgs e){
            loadAllComments();
        }
    }
}
