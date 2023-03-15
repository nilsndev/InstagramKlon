using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealInstagram.Class{
    public class Post : TableBaseClass{
        #region Felder
        int _id;
        int _created_by_user_id;
        DateTime _created_datetime;
        string _caption;
        int _post_type;
        #endregion
        #region Eigenschaften
        public int ID{get{return _id;}}
        public int Created_by_user_id{get{return _created_by_user_id;}}
        public DateTime Created_datetime { get { return _created_datetime;}}
        public string Caption{get{return _caption;}set{_caption = value;}}
        public int Post_type {get{return _post_type;}}
        #endregion
        #region Methoden
        public Post[] GetValuesFromClass(string condition){
            string query = $"SELECT * FROM post";
            if (condition != ""){
                query += " WHERE " + condition;
            }
            List<Post> list = new List<Post>();
            MySqlCommand cmd = new MySqlCommand(query, connectDB);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()){
                Post p = new Post();
                p._id = reader.GetInt32("ID");
                p._created_by_user_id = reader.GetInt32("created_by_user_id");
                p._created_datetime = Convert.ToDateTime(reader.GetString("created_datetime"));
                p._caption = reader.GetString("caption");
                p._post_type = reader.GetInt32("post_type");
                list.Add(p);
            }
            reader.Dispose();
            cmd.Dispose();
            return list.ToArray();
        }
        public Image getPostMedia(int post_id){
            _id = post_id;
            post_media pm = new post_media();
            Image img = pm.getImage(_id);
            return img;
        }
        #region Überschriebene Methoden
        public override void InsertData(int created_by_user_id,int post_type){
            _created_datetime = DateTime.Now;
            _created_by_user_id = created_by_user_id;
            _post_type = post_type;
            string query = $"INSERT INTO post (created_by_user_id,created_datetime,caption,post_type) " +
                            $"values ({_created_by_user_id},'{_created_datetime}','{_caption}',{_post_type})";
            executeQuery(query);
        }
     /*   public override void UpdateData(int id,string caption){
         /   _id = id;
            _caption = caption;

            string query = $"";
            executeQuery(query);
        }*/
        public override void DeleteData(int post_id,int user_id){
            _id = post_id;
            _created_by_user_id = user_id;
            post_media pm = new post_media();
            pm.DeleteData(_id);
            //reaction
            string query = $"DELETE FROM reaction " +
                    $"WHERE post_id = {_id}";
            executeQuery(query);
            //========
            //Comment
            query = $"DELETE FROM comment " +
                    $"WHERE post_id = {_id}";
            executeQuery(query);
            //=======¨
            query = $"DELETE FROM post " +
                           $"WHERE ID = {_id}";
            executeQuery(query);
           

        }
        public override int returnRowsFromExecuteQuery(int id){
            _created_by_user_id = id;
            string query = $"SELECT COUNT(*) FROM WHERE created_by_user_id = {id}";
            string condition = $"created_by_user_id = {_created_by_user_id}";
            int rowCount = base.returnRowsFromExecutedQuery("post",condition);
            return rowCount;
        }
        #endregion
        #endregion

    }
}
