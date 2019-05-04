using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProductManage
{
    class DBHelper : IDisposable
    {
        private static string conn = "server=host; database=db; uid=user; password=pass; connect timeout=30;";
        private MySqlConnection connection;
        public DBHelper()
        {
            connection = new MySqlConnection(conn);
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void Dispose()
        {
            this.Close();
            connection.Dispose();
        }
    }
}
