using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MySQLStatusCheck
{
    public class ConnectionCounter
    {
        private readonly MySqlConnection connection;

        public ConnectionCounter()
        {
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnMySql"].ConnectionString);
        }

        public void DoConnect()
        {
            Open();
            string stop = "";
        }

        public void DoConnectWithUsing()
        {
            using (connection)
            {
                Open();
                string stop = "";
            }
        }

        private void Open()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
