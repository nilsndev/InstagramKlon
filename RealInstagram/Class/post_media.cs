using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RealInstagram.Class{
    public class post_media : TableBaseClass{
        #region Felder
        int _id;
        int _post_id;
        Image _media_file;
        int _position;// First Image, Second Image, Third Image usw.
        #endregion
        #region Eigenschaften
        public int ID { get { return _id; }}
        public int Post_id { get { return _post_id; }}
        public Image Media_file { get { return _media_file; } set{ _media_file = value; }}
        public int Position{get{return _position;}}
        #endregion
        #region Methoden
        #region Überschriebene Methoden
        public override void InsertData(int post_id,int position,Image img){
            _position = position;
            _post_id = post_id;
            string imgTag = "@ProfileImage";
            string query = $"INSERT INTO post_media (post_id,media_file,position) " +
                            $"values ({_post_id},{imgTag},{_position})";
            ExecuteWithIMG(img, query, imgTag);
        }
        public override Image getImage(int post_id){
            _post_id = post_id;
            string query = $"SELECT media_file FROM post_media WHERE post_id ={_post_id}";
            Image img = getImageBase(query, "post_media", "media_file");
            return img;
        }
        public override void UpdateData(int id){
            throw new NotImplementedException();
        }
        public override void DeleteData(int post_id){
            _post_id= post_id;
            string query = $"DELETE FROM post_media " +
                           $"WHERE post_id = {_post_id}";
            executeQuery(query);
        }
        #endregion
        #endregion
    }
}
