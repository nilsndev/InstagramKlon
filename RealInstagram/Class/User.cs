using MySql.Data.MySqlClient;
using RealInstagram.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RealInstagram.Class{
    public class User : TableBaseClass{
        #region Felder
        int _id;
        string _first_name;
        string _last_name;
        string _user_name;
        string _password;
        DateTime _singup_Date;
        #endregion
        #region Eigenschaften
        public int Id { get { return _id; }}
        public string FirstName { get{ return _first_name;}set{ _first_name = value;}}
        public string LastName {get{return _last_name;}set{ _last_name = value;}}
        public string UserName {get{return _user_name;}set{_user_name = value;}}
        public string Password{get{return _password;}set{_password = value;}}
        public DateTime SingupDate{get{return _singup_Date;}}
        #endregion
        #region Methoden
        public bool userExists(){
            int rowCount = 0;
            string query = $"SELECT COUNT(*) FROM user WHERE user_name = '{_user_name}'";
            string condition = $"user_name = '{_user_name}'";
            rowCount = returnRowsFromExecutedQuery("user",condition);
            if(rowCount> 0){
                return true;
            }
            return false;
        }
        public bool loginSuccess(){
            int rowCount = 0;
            string query = $"SELECT COUNT(*) FROM user WHERE user_name = '{_user_name}' AND user_password = '{_password}'";
            string condition = $"user_name = '{_user_name}' AND user_password = '{_password}'";
            rowCount = returnRowsFromExecutedQuery("user",condition);
            if (rowCount == 1){
                query = $"SELECT ID FROM user WHERE user_name = '{_user_name}' AND user_password = '{_password}'";
                _id = getLastInsertedID(query);
                Settings.Default.activeUserID = _id;
                Settings.Default.activeUserName= _user_name;
                Settings.Default.activeUserPassword= _password;
                return true;
            }
            return false;
        }
        #region Überschriebene Methoden
        public override void InsertData(){
            _singup_Date = DateTime.Now;
            string query = $"INSERT INTO user (first_name,last_name,user_name,singup_date,user_password) " +
                            $"values ('{_first_name}','{_last_name}','{_user_name}','{_singup_Date.ToString("dd-MM-yyyy")}','{_password}')";
            executeQuery(query);
        }
        public override void UpdateData(int id){
            Settings.Default.activeUserName = _user_name;
            Settings.Default.activeUserPassword = _password;
            _id = id;
            string query = $"UPDATE user" +
                            $" SET user_name = '{_user_name}', user_password = '{_password}' " +
                            $"WHERE ID = {_id}";
            executeQuery(query);
        }
        public override void DeleteData(int id){
            _id = id;
            string query = $"DELETE FROM user WHERE ID = {_id}";
            executeQuery(query);
        }
        #endregion
        #endregion
    }
}
