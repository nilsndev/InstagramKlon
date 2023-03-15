using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealInstagram.Class{
    public class Post_Type : TableBaseClass{
        #region Felder
        int _id;
        string _post_type_name;
        #endregion
        #region Eigenschaften
        public int ID { get { return _id; } }
        public string Post_type_name { get { return _post_type_name; }set { _post_type_name = value; } }
        #endregion
        #region Methoden
        public string[] ReadValuesOfPostType(){
            string query = "SELECT * FROM instagram.post_type";
            string[] postTypes = returnValuesFromExecutedQuery<string>(query, "post_type_name");
            return postTypes;
        }
        #region Überschriebene Methoden
        #endregion
        #endregion
    }
}
