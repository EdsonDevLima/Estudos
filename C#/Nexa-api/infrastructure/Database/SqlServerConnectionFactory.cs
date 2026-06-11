using System.Data;
using Microsoft.Data.SqlClient;
using Nexa.Infrastructure.Database;

namespace SystemSaudeApi.Infrastructure.Database;

public class SqlServerConnectionFactory : IDbConnectionFactory
{
    private readonly IConfiguration _configuration;

    public SqlServerConnectionFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IDbConnection CreateConnection()
    {
        var connectionString = _configuration.GetConnectionString("Default");

        return new SqlConnection(connectionString);
    }
}