using System.Data.SqlClient;

namespace ColegioSISE.Data.Connection
{
    public class ConnectionDB
    {
        private static readonly string connectionString 
            = "Server=localhost\\SQLEXPRESS;Database=bd_colegiosisenotas;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
