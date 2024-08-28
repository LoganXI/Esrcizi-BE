using System.Data;
using System.Data.SqlClient;

namespace TestS4L5BEAppPolizia.Services
{
    public class DatabaseContext
    {
        private readonly string? _connectionString;

        public DatabaseContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Appconn");
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
