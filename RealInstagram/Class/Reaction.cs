using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealInstagram.Class{
    public class Reaction : TableBaseClass{
        #region Felder
        int _user_id;
        int _post_id;
        #endregion
        #region Eigenschaften
        public int User_id { get { return _user_id; }}
        public int Post_id { get { return _post_id; }}
        #endregion
        #region Methoden
        #region Überschriebene Methoden
        public override void InsertData(int user_id,int post_id){
            _user_id = user_id;
            _post_id = post_id;
            string query = $"INSERT INTO reaction (user_id,post_id) " +
                            $"values ({_user_id},{_post_id})";
            executeQuery(query);
        }
        public override void UpdateData(int id){
            throw new NotImplementedException();
        }
        public override void DeleteData(int user_id,int post_id){
            _user_id = user_id;
            _post_id = post_id;
            string query = $"DELETE FROM reaction " +
                            $"WHERE user_id = {_user_id} AND post_id ={_post_id}";
            executeQuery(query);
        }
        #endregion
        #endregion
    }
}
