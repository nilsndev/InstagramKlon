using RealInstagram.Class;
using RealInstagram.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealInstagram.Properties;
namespace RealInstagram.Controls{
    public partial class PostField : UserControl{
        public PostField(){
            InitializeComponent();
        }
        private void caption_label1_Click(object sender, EventArgs e){
        }
        private void post_media_pictureBox1_Click(object sender, EventArgs e){
        }

        private void PostField_Load(object sender, EventArgs e){
            loadCustomData();
            checkifLiked();
            getLikeCount();
            CheckOwnPost();
        }
        void CheckOwnPost(){
            if(Settings.Default.activeUserID.ToString() == this.user_id_label1.Text){
                this.delete_post_button1.Visible = true;
            }
        }
        void loadCustomData(){
            Post post = new Post();
            Profile profile = new Profile();
            int id = Convert.ToInt32(this.post_id_label1.Text);
            this.post_media_pictureBox1.Image = post.getPostMedia(id);
            string condition = $"ID = {id}";
            int user_id = post.returnValueFromExecutedQuery<int>("post", condition, "created_by_user_id");
            condition = $"user_id = {user_id}";
            this.profile_name_label1.Text = profile.returnValueFromExecutedQuery<string>("profile", condition, "profile_name");
            this.profile_pictureBox1.Image = profile.getImage(user_id);
        }
        void checkifLiked(){
            Reaction reaction = new Reaction();
            string condition = $"user_id = {Settings.Default.activeUserID} AND post_id = {post_id_label1.Text}";
            int rowCount = reaction.returnRowsFromExecutedQuery("reaction",condition);
            if(rowCount > 0){
                this.like_button1.Text = "Liked";
            }
            else{
                this.like_button1.Text = "Like";
            }
        }
        void getLikeCount(){
            Reaction reaction = new Reaction();
            string condition = $"post_id = {post_id_label1.Text}";
            int rowCount = reaction.returnRowsFromExecutedQuery("reaction", condition);
            this.like_count_label1.Text = $"Like {rowCount}  Times";
        }
        private void likeComment_area_panel1_Paint(object sender, PaintEventArgs e){
        }

        private void profile_panel1_Click(object sender, EventArgs e){
            viewProfileForm vpf = new viewProfileForm();
            vpf.profile_pictureBox1.Image = profile_pictureBox1.Image;
            vpf.anzeige_name_label1.Text = profile_name_label1.Text;
            vpf.user_id_label1.Text = user_id_label1.Text;
            if (this.user_id_label1.Text == Settings.Default.activeUserID.ToString()){
                vpf.follow_button1.Visible = false;
            }
            vpf.ShowDialog();
        }
        private void like_button1_Click(object sender, EventArgs e){
            Reaction reaction = new Reaction();
            int user_id = Settings.Default.activeUserID;
            int post_id = Convert.ToInt32(this.post_id_label1.Text);
            if (like_button1.Text == "Like"){
                reaction.InsertData(user_id,post_id);
                like_button1.Text = "Liked";
            }
            else{
                reaction.DeleteData(user_id,post_id);
                like_button1.Text = "Like";
            }
            getLikeCount();
        }

        private void delete_post_button1_Click(object sender, EventArgs e){
            Post post = new Post();
            int post_id = Convert.ToInt32(this.post_id_label1.Text);
            int user_id = Convert.ToInt32(this.user_id_label1.Text);
            post.DeleteData(post_id, user_id);
            this.Dispose();
        }

        private void comment_button1_Click(object sender, EventArgs e){
            Comment_Form cf = new Comment_Form();
            cf.post_id_label1.Text = this.post_id_label1.Text;
            cf.ShowDialog();
        }
    }
}
