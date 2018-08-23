using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite
{
    public class SqlUtil
    {
        SQLiteConnection dbConnection;

        public SqlUtil(string dataSource = "MyDatabase.sqlite")
        {
            dbConnection = new SQLiteConnection("Data Source=" + dataSource + ";Version=3;");
            dbConnection.Open();
        }

        public SqlUtil(SQLiteConnection dbConnection)
        {
            this.dbConnection = dbConnection;

            if(this.dbConnection.State != System.Data.ConnectionState.Open)
                this.dbConnection.Open();
        }


        public int ExecuteScalarInt(string sql)
        {
            var command = new SQLiteCommand(sql, dbConnection);
            var valueObject = command.ExecuteScalar();

            return  Convert.ToInt32(valueObject);
        
        }

        public void ExecuteNonQuery(string sql)
        {
            var command = new SQLiteCommand(sql, dbConnection);
            var status = command.ExecuteNonQuery();
        }

        public int GetRecCount(string tableName)
        {
            var sql = " select count(*) count from " + tableName;
            return this.ExecuteScalarInt(sql);
        }

        public  bool Exists(string tableName)
        {
            var sql = " SELECT count(*) FROM sqlite_master WHERE type='table' AND name='" + tableName + "' ";
             return ( this.ExecuteScalarInt(sql) > 0);
        }
    }
}
