using MySql.Data.MySqlClient;
using RealInstagram.Class;
using RealInstagram.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealInstagram.Forms
{
    public partial class NewPostForm : Form{
        Post activePost = new Post();
        public NewPostForm()
        {
            InitializeComponent();
        }
        void setValuesFromPost(){
        }

        private void NewPostForm_Load(object sender, EventArgs e){

        }

        private void submit_button1_Click(object sender, EventArgs e){
            int user_id = Settings.Default.activeUserID;
            int post_id = 0;
            //--------Post----------------------------------------
            Post post = new Post();
            post.Caption = this.caption_textBox1.Text;
            post.InsertData(user_id,1);
            post_id = post.getLastInsertedID("SELECT MAX(ID) FROM post");
            //====================================================
            //-------Post-Media-----------------------------------
            post_media pm = new post_media();
            //pm.Post_id =
            Image img = this.post_img_pictureBox1.Image;
            pm.InsertData(post_id,1,img);
            //====================================================
            MessageBox.Show("Success!");
            this.Close();
        }
        

        private void select_img_button1_Click(object sender, EventArgs e){
            
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            post_img_pictureBox1.Image =Image.FromFile(openFileDialog1.FileName);
        }
    }
}
