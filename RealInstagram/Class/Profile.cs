using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using RealInstagram.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace RealInstagram.Class{
    public class Profile : TableBaseClass{
        #region Felder
        int _id;
        string _profile_name;
        Image _profile_img;
        int _user_id;
        #endregion
        #region Eigenschaften
        public int ID { get { return _id; } }
        public string Profile_name{get{return _profile_name;} set{_profile_name = value;}}
        public Image Profile_img{get{return _profile_img; } set { _profile_img = value;}}
        public int User_id { get { return _user_id; } }
        #endregion
        #region Methoden
        public void getIDbyUserID(int user_id){
            _user_id = user_id;
            string query = $"SELECT * FROM profile WHERE user_id ={_user_id}";
            _id = getLastInsertedID(query);
            Settings.Default.activeProfileID = _user_id;
        }
        public Profile[] GetValuesFromClass(string value){
            string query = $"SELECT * FROM profile WHERE profile_name LIKE '%{value}%'";
            List<Profile> list = new List<Profile>();
            MySqlCommand cmd = new MySqlCommand(query, connectDB);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()){
                Profile p = new Profile();
                p._id = reader.GetInt32("ID");
                p._user_id = reader.GetInt32("user_id");
                p._profile_name = reader.GetString("profile_name");
                p._profile_img = p.getImage(p._user_id);
                list.Add(p);
            }
            reader.Dispose();
            cmd.Dispose();
            return list.ToArray();
        }
        public override Image getImage(int user_id){
            try
            {
                _user_id = user_id;
                string query = $"SELECT profile_img FROM profile WHERE user_id ={_user_id}";
                Image img = getImageBase(query, "profile", "profile_img");
                return img;
            }catch(Exception ex){}
            return null;
        }
        #region Überschriebene Methoden
        public override void InsertData(int user_id){
            _user_id = getLastInsertedID("SELECT MAX(ID) FROM user");
            _profile_img = null;
            string query = $"INSERT INTO profile (profile_name,user_id) " +
                           $"values ('{_profile_name}',{_user_id})";
            //executeQuery(query);
            executeQuery(query);
        }
        public override void UpdateData(int user_id,string imgTag,Image img){
            _user_id = user_id;
            string query = $"UPDATE profile " +
                             $"SET profile_name = '{_profile_name}', profile_img = {imgTag} " +
                             $"WHERE user_id ={_user_id}";
            ExecuteWithIMG(img, query, imgTag);
        }
        #endregion
        #endregion
    }
}
