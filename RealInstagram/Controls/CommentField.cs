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

namespace RealInstagram.Controls
{
    public partial class CommentField : UserControl
    {
        public CommentField()
        {
            InitializeComponent();
        }

        private void CommentField_Load(object sender, EventArgs e){
            load_img();
            checkOwnComment();
        }
        void checkOwnComment(){
          // if(SettingsBi)
        }
        void load_img(){
            Profile profile= new Profile();
            int user_id = Convert.ToInt32(this.user_id_label1.Text);
            this.user_img_pictureBox1.Image = profile.getImage(user_id);
        }
    }
}
