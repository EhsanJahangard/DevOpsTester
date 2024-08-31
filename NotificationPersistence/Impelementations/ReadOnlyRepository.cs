using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NotificationApplication.Contracts.Repositories;
using System.Data;
namespace NotificationPersistence.Impelementations;

public class ReadOnlyRepository : IReadOnlyRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;
    public IDbConnection Connection { get; set; }

    public ReadOnlyRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("SqlConnection");
        Connection = new SqlConnection(_connectionString); ;
    }
}
