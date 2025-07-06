using MySql.Data.MySqlClient;

namespace AplikasiPenjualanParfum.Model
{
    public class DBConnect
    {
        private MySqlConnection conn;

        public DBConnect()
        {
            conn = new MySqlConnection(Helper.ConnectionString);
        }

        public MySqlConnection GetConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}