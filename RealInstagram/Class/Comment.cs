using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealInstagram.Class{
    public class Comment : TableBaseClass{
        #region Felder
        int _id;
        int _created_by_user_id;
        int _post_id;
        DateTime _created_datetime;
        string _comment_text;
        #endregion
        #region Eigenschaften
        public int ID { get {return _id;}}
        public int Created_by_user_id{get{return _created_by_user_id;}}
        public int Post_id{get{return _post_id;}}
        public DateTime Created_datetime{get{return _created_datetime;}}
        public string Comment_text{get{return _comment_text;}set{_comment_text = value;}}
        #endregion
        #region Methoden
        #region Überschriebene Methoden
        public override void InsertData(int created_by_user_id,int post_id){
            _created_datetime = DateTime.Now;
            _created_by_user_id = created_by_user_id;
            _post_id = post_id;
            string query = $"INSERT INTO comment (created_by_user_id,post_id,created_datetime,comment_text) " +
                           $"values ({_created_by_user_id},{_post_id},'{_created_datetime}','{_comment_text}')";
            executeQuery(query);
        }
        public Comment[] GetValuesFromClass(string condition){
            string query = $"SELECT * FROM comment";
            if (condition != ""){
                query += " WHERE " + condition;
            }
            List<Comment> list = new List<Comment>();
            MySqlCommand cmd = new MySqlCommand(query, connectDB);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()){
                Comment com = new Comment();
                com._id = reader.GetInt32("ID");
                com._created_by_user_id = reader.GetInt32("created_by_user_id");
                com._created_datetime = Convert.ToDateTime(reader.GetString("created_datetime"));
                com._post_id = reader.GetInt32("post_id");
                com._comment_text = reader.GetString("comment_text");
                list.Add(com);
            }
            reader.Dispose();
            cmd.Dispose();
            return list.ToArray();
        }
        public override void UpdateData(int id){
            throw new NotImplementedException();
        }
        public override void DeleteData(int id){
            _id = id;
            string query = $"Delete From comment WHERE ID = {_id}";
            
        }
        #endregion
        #endregion
    }
}
