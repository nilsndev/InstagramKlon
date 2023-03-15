using RealInstagram.Class;
using RealInstagram.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealInstagram.Forms
{
    public partial class Edit_User_Form : Form
    {
        public Edit_User_Form()
        {
            InitializeComponent();
        }

        private void Edit_User_Form_Load(object sender, EventArgs e)
        {

        }

        private void select_image_button1_Click(object sender, EventArgs e){
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK){
                this.user_image_pictureBox1.ImageLocation = openFileDialog1.FileName;
            }

        }

        private void submit_changes_button1_Click(object sender, EventArgs e){
            this.DialogResult = DialogResult.OK;
        }
    }
}
