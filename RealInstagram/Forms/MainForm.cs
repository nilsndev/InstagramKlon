using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using RealInstagram.Properties;
using RealInstagram.Class;
using RealInstagram.Controls;

namespace RealInstagram.Forms{
    public partial class MainForm : Form{
        public MainForm(){
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e){
            Login_Form lf = new Login_Form();
            lf.ShowDialog();
            loadActiveuserData();
            LoadPosts();
            loadOwnPosts();
        }
        private void posts_tabPage1_Click(object sender, EventArgs e){
        }
        #region ProfileTabControl
        private void profile_tabPage2_Click(object sender, EventArgs e){

        }
        private void profile_tabPage2_Enter(object sender, EventArgs e){
            this.posts_panel1.Controls.Clear();
            loadFollowandPostCount();
            loadOwnPosts();
        }
        void loadFollowandPostCount(){
            follower follower= new follower();
            Post post = new Post();
            int postCount = post.returnRowsFromExecuteQuery(Settings.Default.activeUserID);
            int followers = follower.returnRowsFromExecutedQuery("follower", $"followed_user_id = {Settings.Default.activeUserID}");
            int following = follower.returnRowsFromExecutedQuery("follower", $"following_user_id = {Settings.Default.activeUserID}");
            this.posts_count_value_label1.Text = postCount.ToString();
            this.followers_value_label1.Text = followers.ToString();
            this.following_value_label1.Text = following.ToString();
        }
        void loadOwnPosts(){
            int index = 0;
            int size = this.posts_panel1.Width / 8;
            string condition = $"created_by_user_id = {Settings.Default.activeUserID}";
            Post[] post = (new Post()).GetValuesFromClass(condition);
            int maxRow = 1;
            int value = post.Length / 8;
            try{
                for (int j = 0; true; j++){
                    for (int i = 0; i < 8; i++){
                        index = j * 8 + i;
                        PictureBox pb = new PictureBox();
                        pb.BorderStyle = BorderStyle.FixedSingle;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Size = new Size(size, size);
                        pb.Tag = post[index].ID;
                        pb.Click += postPictureboxes_Click;
                        pb.Location = new Point(i * size, j*size);
                        pb.Image = post[index].getPostMedia(post[index].ID);
                        this.posts_panel1.Controls.Add(pb);
                    }
                }
            }catch{
            }
        }
        void postPictureboxes_Click(object sender, EventArgs e){
            PictureBox pb = sender as PictureBox;
            viewPostForm vpf = new viewPostForm();
            vpf.post_id_label1.Text = pb.Tag.ToString();
            vpf.post_media_pictureBox1.Image = pb.Image;
            vpf.ShowDialog();
        }
        void loadActiveuserData(){
            try{
                this.anzeige_name_label1.Text = Settings.Default.activeUserName;
                Profile p = new Profile();
                follower follower = new follower();
                Post post = new Post();
                this.profile_pictureBox1.Image =p.getImage(Settings.Default.activeUserID);
                loadFollowandPostCount();
            }catch(Exception ex){
            }
        }
        private void edit_profile_button1_Click(object sender, EventArgs e){
            Edit_User_Form euf = new Edit_User_Form();
            euf.user_name_textBox1.Text = Settings.Default.activeUserName;
            euf.user_pass_textBox1.Text = Settings.Default.activeUserPassword;
            if(this.profile_pictureBox1.Image != null){
                euf.user_image_pictureBox1.Image = this.profile_pictureBox1.Image;
            }
            euf.ShowDialog();
            if(euf.DialogResult == DialogResult.OK){
                saveProfileChanges(euf);
            }
        }
        void saveProfileChanges(Edit_User_Form euf){
            string query;
            //-----Update User----------------------------
            User user = new User();
            user.Password = euf.user_pass_textBox1.Text;
            user.UserName = euf.user_name_textBox1.Text;
            user.UpdateData(Settings.Default.activeUserID);
            //============================================
            //-----Update Profile-------------------------
            Profile profile = new Profile();
            string imgTag = "@ProfileImage";
            profile.Profile_name = euf.user_name_textBox1.Text;
            Image img = euf.user_image_pictureBox1.Image;
            query = "";
            profile.UpdateData(Settings.Default.activeUserID,imgTag,img);
            //============================================
            //---------Save Image--------------------------- 
            this.anzeige_name_label1.Text = Settings.Default.activeUserName;
            this.profile_pictureBox1.Image = euf.user_image_pictureBox1.Image;
            //==============================================
        }
        private void addPost_button1_Click(object sender, EventArgs e){
            NewPostForm npf = new NewPostForm();
            npf.ShowDialog();
            npf.Dispose();
        }
        #endregion
        #region PostsTabControl
        private void posts_tabPage1_Enter(object sender, EventArgs e){
            LoadPosts();
        }
        void LoadPosts(){
            this.posts_tabPage1.Controls.Clear();
            Post[] p = (new Post()).GetValuesFromClass("");            
            int width = (this.posts_tabPage1.Width - (new PostField()).Width) / 2;
            for (int i = 0; i < p.Count(); i++){
                PostField pf = new PostField();
                pf.post_id_label1.Text = p[i].ID.ToString();
                pf.caption_label1.Text = p[i].Caption;
                pf.Location = new Point(width, i * (pf.Height +20));
                string condition = $"ID  = {pf.post_id_label1.Text} ";
                int user_id = (new Post()).returnValueFromExecutedQuery<int>("post",condition, "created_by_user_id");
                pf.user_id_label1.Text = user_id.ToString(); 
                this.posts_tabPage1.Controls.Add(pf);
            }
        }
        #endregion
        #region SearchTabControl
        private void search_button1_Click(object sender, EventArgs e){
            this.searched_user_panel1.Controls.Clear();
            Profile p = new Profile();
            Profile[] pArr = p.GetValuesFromClass(this.search_textBox1.Text);
            for (int i = 0; i < pArr.Length; i++){
                SearchUserField suf = new SearchUserField();
                suf.user_name_value_label1.Text = pArr[i].Profile_name;
                suf.user_id_label2.Text = pArr[i].User_id.ToString();
                suf.user_pictureBox1.Image = pArr[i].Profile_img;
                suf.Location = new Point(0, i * suf.Height);
                this.searched_user_panel1.Controls.Add(suf);
            }
        }
        #endregion

        private void logout_button1_Click(object sender, EventArgs e){
            Login_Form lf = new Login_Form();
            lf.ShowDialog();
            if(lf.DialogResult== DialogResult.OK){
                loadActiveuserData();
                LoadPosts();
                loadOwnPosts();
                this.instagram_tabControl1.SelectedIndex= 0;
            }
        }
    }
}
