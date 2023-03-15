using RealInstagram.Class;
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
using System.Reflection;

namespace RealInstagram.Forms{
    public partial class viewProfileForm : Form{
        int followerCount = 0;
        public viewProfileForm(){
            InitializeComponent();
        }
        private void viewProfileForm_Load(object sender, EventArgs e){
            showPostFollowUswData();
            checkifFollowed();
            loadPosts();
            followerCount = Convert.ToInt32(followerCount);
        }
        void showPostFollowUswData(){
            Post post = new Post();
            follower follower = new follower();
            int followers = follower.returnRowsFromExecutedQuery("follower", $"followed_user_id = {this.user_id_label1.Text}");
            int following = follower.returnRowsFromExecutedQuery("follower", $"following_user_id = {this.user_id_label1.Text}");
            int postCount = post.returnRowsFromExecutedQuery("post", $"created_by_user_id = {this.user_id_label1.Text}");
            this.posts_value_label1.Text = postCount.ToString();
            this.followers_value_label1.Text = followers.ToString();
            this.following_value_label1.Text = following.ToString();
        }
        void checkifFollowed(){
            follower follower = new follower();
            string condition = $"following_user_id = {Settings.Default.activeUserID} AND followed_user_id = {user_id_label1.Text}";
            int rows = follower.returnRowsFromExecutedQuery("follower", condition);
            if(rows > 0){
                this.follow_button1.Text = "followed";
            }
        }
        void loadPosts(){
            int index = 0;
            int size = this.posts_panel1.Width / 8;
            string condition = $"created_by_user_id = {this.user_id_label1.Text}";
            Post[] post = (new Post()).GetValuesFromClass(condition);
            int maxRow = 1;
            if (post.Count() > 8){
                maxRow = post.Count() / 8;
            }
            try{
                for (int j = 0; (true); j++){
                    for (int i = 0; i < 8; i++){
                        index = j * 8 + i;
                        PictureBox pb = new PictureBox();
                        pb.BorderStyle = BorderStyle.FixedSingle;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Size = new Size(size, size);
                        pb.Tag = post[index].ID;
                        pb.Click += postPictureboxes_Click;
                        pb.Location = new Point(i * size, j * size);
                        pb.Image = post[index].getPostMedia(post[index].ID);
                        this.posts_panel1.Controls.Add(pb);
                    }
                }
            }
            catch{}
        }

        void postPictureboxes_Click(object sender, EventArgs e){
            PictureBox pb = sender as PictureBox;
            viewPostForm vpf = new viewPostForm();
            vpf.post_id_label1.Text = pb.Tag.ToString();
            vpf.post_media_pictureBox1.Image = pb.Image;
            vpf.ShowDialog();
        }
        private void follow_button1_Click(object sender, EventArgs e){
            int followed_id = Convert.ToInt32(this.user_id_label1.Text);
            if (this.follow_button1.Text == "follow"){
                addFollower(followed_id);
                this.follow_button1.Text = "followed";
            }
            else{
                removeFollower(followed_id);
                this.follow_button1.Text = "follow";
            }
        }
        void removeFollower(int followed_id){
            follower follower = new follower();
            follower.DeleteData(Settings.Default.activeUserID,followed_id);
            this.follow_button1.Text = "follow";
            followerCount = Convert.ToInt32(this.followers_value_label1.Text);
            followerCount -= 1;
            this.followers_value_label1.Text = followerCount.ToString();
        }
        void addFollower(int followed_id){
            follower follower = new follower();
            follower.InsertData(Settings.Default.activeUserID,followed_id);
            this.follow_button1.Text = "followed";
            followerCount = Convert.ToInt32(this.followers_value_label1.Text);
            followerCount += 1;
            this.followers_value_label1.Text  = followerCount.ToString();
        }
    }
}
