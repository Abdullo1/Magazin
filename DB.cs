using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мagazine
{
    class DB
    {
         static String ConnectionTo = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Local_Db.mdf;Integrated Security=True";
       // static String ConnectionTo = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\desktop\C#\Проект№2\Проверка\Мagazine2\Мagazine2\Мagazine\Local_Db.mdf;Integrated Security=True";
        SqlConnection sql_Connection = new SqlConnection(ConnectionTo);


        public void OpenConnection()
        {
             if ((sql_Connection != null) && (sql_Connection.State != ConnectionState.Open))
                sql_Connection.Open();
        }


        public void CloseConnection()
        {
            if ((sql_Connection != null) && (sql_Connection.State != ConnectionState.Closed))
                sql_Connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return sql_Connection;
        }
    }
}
