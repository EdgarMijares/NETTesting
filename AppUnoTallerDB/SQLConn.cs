using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SQLConn
{
    class SQLConn
    {
        public static SqlConnection connection;
        public static SqlConnection connectionService()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "SA";
            builder.Password = "Hackman1896";
            builder.InitialCatalog = "master";
            return new SqlConnection(builder.ConnectionString);
        }
        public static void OpenConnection()
        {
            connection = connectionService();
            connection.Open();
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        public static void ExecuteQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static SqlDataReader DataQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader data = command.ExecuteReader();
            return data;
        }
        public static object ShowDataGrid(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet collection = new DataSet();
            adapter.Fill(collection);
            object data = collection.Tables[0];
            return data;
        }
        public static SqlCommand queryService(string query)
        {
            return new SqlCommand(query, connectionService());
        }
    }
}