using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace RealInstagram.Class{
    public class Connection_class{
        #region Felder
        public MySqlConnection connectDB;
        string _server = "localhost";
        string _userid = "root";
        #region password
        string _password = "Lolkopf13";
        #endregion
        string _database = "instagram";
        #endregion
        #region Eigenschaften
        public string Server { get {return _server;}}
        public string Userid { get { return _userid;}}
        public string Password { get { return _password;}}
        public string Database { get { return _database;}}
        #endregion
        #region Konstruktor
        public Connection_class(){
            string conStr = $"server={_server};userid={_userid};password={_password};database={_database};";
            connectDB = new MySqlConnection(conStr);
            connectDB.Open();
        }
        #endregion
        #region Methdoen
        public void executeQuery(string query){
            MySqlCommand cmd = new MySqlCommand(query, connectDB);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public T[] returnValuesFromExecutedQuery<T>(string query, string column){
            int rowCount = 0;
            List<T> list = new List<T>();
            MySqlCommand cmd = new MySqlCommand(query, connectDB);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()){
                list.Add((T)reader[column]);  
                rowCount++;
            }
            reader.Dispose();
            cmd.Dispose();
            return list.ToArray();
        }
        public int getLastInsertedID(string query){
            int id = 0;
            MySqlCommand cmd = new MySqlCommand(query,connectDB);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }
      
        public void ExecuteWithIMG(Image img,string query,string imgTag){
            MySqlCommand cmd = new MySqlCommand(query,connectDB);
            if (img != null){
                byte[] data = imageToByte(img);
                MySqlParameter blob = new MySqlParameter(imgTag, MySqlDbType.LongBlob);
                blob.Value = data;
                cmd.Parameters.Add(blob);
                cmd.ExecuteNonQuery();
            }
            cmd.Dispose();
           
        }
        public Image getImageBase(string query,string tableName,string imgColumn){
            try {
            /*_user_id = user_id;
            string query = $"SELECT profile_img FROM profile WHERE user_id ={_user_id}";*/
            MySqlCommand cmd = new MySqlCommand(query, connectDB);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            int count = ds.Tables[tableName].Rows.Count;
            if (count <= 0){
                return null;
            }
            Byte[] byteArr;
            byteArr = (Byte[])(ds.Tables[tableName].Rows[count - 1][imgColumn]);
            MemoryStream msBlobData = new MemoryStream(byteArr);
            Image img = Image.FromStream(msBlobData);
            return img;
            }catch{
            }
            return null;
        }
        byte[] imageToByte(Image img){
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }
        #endregion
    }
}
