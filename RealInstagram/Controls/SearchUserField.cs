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
using RealInstagram.Forms;
using RealInstagram.Properties;

namespace RealInstagram.Controls{
    public partial class SearchUserField : UserControl{
        viewProfileForm vpf = new viewProfileForm();
        public SearchUserField(){
            InitializeComponent();
        }

        private void SearchUserField_Click(object sender, EventArgs e){
            vpf.profile_pictureBox1.Image = user_pictureBox1.Image;
            vpf.anzeige_name_label1.Text = user_name_value_label1.Text;
            vpf.user_id_label1.Text = user_id_label2.Text;
            if(this.user_id_label2.Text == Settings.Default.activeUserID.ToString()){
                vpf.follow_button1.Visible= false;
            }
            vpf.ShowDialog();
        }
        private void SearchUserField_Load(object sender, EventArgs e){
        }
    }
}
