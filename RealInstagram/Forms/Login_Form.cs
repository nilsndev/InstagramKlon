using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using RealInstagram.Class;
using RealInstagram.Properties;

namespace RealInstagram.Forms{
    public partial class Login_Form : Form{
        Connection_class conClass = new Connection_class();

        public Profile Profile { get; private set; }

        public Login_Form(){
            InitializeComponent();
        }
        private void Login_Form_Load(object sender, EventArgs e){

        }
        private void create_account_label1_Click(object sender, EventArgs e){
            this.tabControl1.SelectedIndex = 1;
        }
        #region RegisterTabControl
        private void register_button1_Click(object sender, EventArgs e){
            User newUser = new User();
            Profile newProfile = new Profile();
            if (!insertUserDataCorrect(newUser)){
                return;
            }
            insertProfileData(newProfile, newUser);
            MessageBox.Show("Register Success!");
            clearRegTB();
            this.tabControl1.SelectedIndex = 0;
        }
        bool insertUserDataCorrect(User newUser){
            newUser.UserName = register_username_textBox2.Text;
            newUser.Password = register_password_textBox1.Text;
            newUser.FirstName = first_name_textBox4.Text;
            newUser.LastName = last_name_textBox3.Text;
            if (tbEmptyORPWINcorrect(newUser)){
                return false;
            }
            if (newUser.userExists()){
                MessageBox.Show("Dieser Benutzername ist bereits vergeben");
                return false;
            }
            newUser.InsertData();
            return true;
        }
        void insertProfileData(Profile newProfile,User newUser){
            newProfile.Profile_name = newUser.UserName;
            newProfile.Profile_img = null;
            newProfile.InsertData(Settings.Default.activeUserID);
        }
        void clearRegTB(){
            foreach(Control c in this.register_tabPage2.Controls){
                if(c is TextBox){
                    c.ResetText();
                }
            }
        }
        bool tbEmpty(User user){
            bool condition = (user.UserName == "" || user.Password == "" || user.FirstName == "" || user.LastName == "");
            if (condition){
                return true;
            }
            return false;
        }
        bool tbEmptyORPWINcorrect(User user){
            bool tbEqual = (register_password_textBox1.Text == rewiew_password_textBox1.Text);
            if (tbEmpty(user) || !tbEqual){
                MessageBox.Show("Fehler bei der Registrierung");
                return true;
            }
            return false;
        }
        #endregion
        #region LoginTabControl
        private void login_button1_Click(object sender, EventArgs e){
            User user = new User();
            Profile newProfile = new Profile();
            user.Password = this.login_password_textBox1.Text;
            user.UserName = this.login_user_name_textBox1.Text;
            if (user.loginSuccess()){
                MessageBox.Show("Login Success!");
                newProfile.getIDbyUserID(user.Id);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else{
                this.login_password_textBox1.Text = "";
                this.login_user_name_textBox1.Text = "";
                MessageBox.Show("Fehler beim Login");
            }
        }
        #endregion

        private void login_tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
