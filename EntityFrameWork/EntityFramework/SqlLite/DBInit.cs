using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SQLite;

namespace SqlLite.SampleDB
{
    public static class DBInit
    {

         static SQLiteConnection dbConnection;
         public static SqlUtil GetSqlUtil()
         {
             return new SqlUtil(dbConnection);
         }
  

        public static void Init()
        {
            dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");

            var sqlUtil = new SqlUtil(dbConnection);
           
            if(!sqlUtil.Exists("Person"))
            {
                sqlUtil.ExecuteNonQuery("Create table Person(EmpID int, Name varchar(50), Age int)");

                sqlUtil.ExecuteNonQuery("insert into Person(EmpID , Name , Age ) select 1, 'sakthi', 40 ");
                sqlUtil.ExecuteNonQuery("insert into Person(EmpID , Name , Age ) select 2, 'sakthi2', 41 ");
            }


        }

        
    }
}

namespace SqlLite.SampleDB.TableMetadata
{

    public static class Person
    {
        public static string Name = "Person";
        public static int InitSize = 2;
    }
}
