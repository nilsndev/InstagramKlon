using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealInstagram.Class{
    public class follower : TableBaseClass{
        #region Felder
        int _following_user_id;
        int _followed_user_id;
        #endregion
        #region
        public int Following_user_id{get{return _following_user_id;}}
        public int Followed_user_id{get{return _followed_user_id;}}
        #endregion
        #region Methoden
        #region Überschriebene Methoden
        public override void InsertData(int following_user_id,int followed_user_id){
            _following_user_id = following_user_id;
            _followed_user_id = followed_user_id;
            string query = $"INSERT INTO follower (following_user_id,followed_user_id) " +
                            $"values ({_following_user_id},{_followed_user_id})";
            executeQuery(query);
        }
        public override void UpdateData(int id){
            throw new NotImplementedException();
        }
        public override void DeleteData(int following_user_id, int followed_user_id){
            _following_user_id=following_user_id;
            _followed_user_id = followed_user_id;
            string query = $"DELETE FROM follower " +
                           $"WHERE following_user_id = {following_user_id} AND followed_user_id = {followed_user_id}";
            executeQuery(query);
        }
        #endregion

        #endregion
    }
}
