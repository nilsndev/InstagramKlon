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
    public partial class viewPostForm : Form{
        
        public viewPostForm()
        {
            InitializeComponent();
        }

        private void viewPostForm_Load(object sender, EventArgs e){
           loadCustomData();
           checkifLiked();
           getLikeCount();
           checkOwnPost();

        }
        void checkOwnPost(){
            Post post = new Post();
            int user_id;
            string condition = $"ID = {this.post_id_label1.Text}";
            user_id = post.returnValueFromExecutedQuery<int>("post", condition, "created_by_user_id");

            if (user_id == Settings.Default.activeUserID){
                this.delet_button1.Visible= true;
            }
        }
        void getLikeCount(){
            Reaction reaction = new Reaction();
            string condition = $"post_id = {post_id_label1.Text}";
            int rowCount = reaction.returnRowsFromExecutedQuery("reaction", condition);
            this.like_count_label1.Text = $"Like {rowCount}  Times";
        }
        void loadCustomData(){
            int user_id;
            Post post = new Post();
            Profile profile = new Profile();
            string condition = $"ID = {this.post_id_label1.Text}";
            user_id = post.returnValueFromExecutedQuery<int>("post", condition, "created_by_user_id");
            this.caption_label1.Text = post.returnValueFromExecutedQuery<string>("post", condition, "caption");
            condition = $"user_id = {user_id}";
            this.profile_name_label1.Text = profile.returnValueFromExecutedQuery<string>("profile", condition, "profile_name");
            this.profile_pictureBox1.Image = profile.getImage(user_id);
        }
        void checkifLiked(){
            Reaction reaction = new Reaction();
            string condition = $"user_id = {Settings.Default.activeUserID} AND post_id = {post_id_label1.Text}";
            int rowCount = reaction.returnRowsFromExecutedQuery("reaction", condition);
            if (rowCount > 0)
            {
                this.like_button1.Text = "Liked";
            }
            else
            {
                this.like_button1.Text = "Like";
            }
        }

        private void caption_label1_Click(object sender, EventArgs e)
        {

        }

        private void like_button1_Click(object sender, EventArgs e){
            Reaction reaction = new Reaction();
            int post_id = Convert.ToInt32(this.post_id_label1.Text);
            if (like_button1.Text == "Like"){
                reaction.InsertData(Settings.Default.activeUserID, post_id);
                like_button1.Text = "Liked";
            }
            else{
                reaction.DeleteData(Settings.Default.activeUserID, post_id);
                like_button1.Text = "Like";
            }
            getLikeCount();
        }

        private void likeComment_area_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delet_button1_Click(object sender, EventArgs e){
            Post post = new Post();
            int post_id = Convert.ToInt32(this.post_id_label1.Text);
            string condition = $"ID = {this.post_id_label1.Text}";
            int user_id = post.returnValueFromExecutedQuery<int>("post", condition, "created_by_user_id");
            post.DeleteData(post_id,user_id);
            this.Close();

        }

        private void comment_button1_Click(object sender, EventArgs e){
            Comment_Form cf = new Comment_Form();
            cf.post_id_label1.Text = this.post_id_label1.Text;
            cf.ShowDialog();

        }
    }
}
