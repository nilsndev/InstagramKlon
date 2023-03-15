using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealInstagram.Class{
    public abstract class TableBaseClass : Connection_class{
        #region Felder
        #endregion
        #region Eigenschaften
        #endregion
        #region Methoden
        #region Virtuelle Methoden
        public int returnRowsFromExecutedQuery(string tableName,string condition){
            string query = "SELECT COUNT(*) FROM @TABLE WHERE @condition";
            int rowCount = 0;
            query = query.Replace("@TABLE", tableName);
            query = query.Replace("@condition", condition);
            MySqlCommand cmd = new MySqlCommand(query, connectDB);
            rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            return rowCount;
        }
        public T returnValueFromExecutedQuery<T>(string tableName,string condition,string column){
            string query = "SELECT @column FROM @TABLE WHERE @condition";
            T value;
            query = query.Replace("@TABLE", tableName);
            query = query.Replace("@condition", condition);
            query = query.Replace("@column", column);
            MySqlCommand cmd = new MySqlCommand(query, connectDB);
            value = (T)cmd.ExecuteScalar();
            cmd.Dispose();
            return value;
        }
        public virtual int returnRowsFromExecuteQuery(int id){
            throw new NotImplementedException();
        }
        public virtual Image getImage(int id){
            throw new NotImplementedException();
        }
        #region Insert Methoden
        public virtual void InsertData(){
            throw new NotImplementedException();
        }
        public virtual void InsertData(int id1){
            throw new NotImplementedException();
        }
        public virtual void InsertData(int id1, int id2){
            throw new NotImplementedException();
        }
        public virtual void InsertData(int id1, int id2, Image img){
            throw new NotImplementedException();
        }
        #endregion
        #region Update Methodenb
        public virtual void UpdateData(int id){
            throw new NotImplementedException();
        }
        public virtual void UpdateData(int id, string text1, Image img){
            throw new NotImplementedException();
        }
        #endregion
        public virtual void DeleteData(int id){
            throw new NotImplementedException();
        }
        public virtual void DeleteData(int id1,int id2){
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
