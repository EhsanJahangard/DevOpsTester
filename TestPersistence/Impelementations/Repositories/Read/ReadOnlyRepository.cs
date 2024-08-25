using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using TestApplication.Contracts.Repositories.Read;

namespace TestPersistence.Impelementations.Repositories.Read
{
    public class ReadOnlyRepository : IReadOnlyRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public IDbConnection Connection { get; set; }

        public ReadOnlyRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlServer");
            Connection = new SqlConnection(_connectionString); ;
        }
    }
}
