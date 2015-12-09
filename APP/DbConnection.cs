using System.Data;
using System.Data.SqlClient;

namespace APP
{
    public class DbConnection
    {
        private SqlCommand _command;
        private SqlConnection _connection;
        public static string ConnectionString { private get; set; }

        public const int MssqlEng002627 = 2627; //Violation of %ls constraint '%.*ls'. Cannot insert duplicate key in object '%.*ls'.
        
        public void OpenConnection()
        {
            _connection = new SqlConnection(ConnectionString);
            _connection.Open();
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public DataTable ExcuteReader(string sql)
        {
            var table = new DataTable();
            var adapter = new SqlDataAdapter(sql, _connection);
            adapter.Fill(table);
            return table;
        }

        public void ExcuteNonQuery(string sql)
        {
            _command = new SqlCommand(sql, _connection);
            _command.ExecuteNonQuery();
        }

        public object ExecuteScalar(string sql)
        {
            _command = new SqlCommand(sql, _connection);
            return _command.ExecuteScalar();
        }
    }
}