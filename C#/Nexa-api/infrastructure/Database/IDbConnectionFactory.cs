using System.Data;

namespace TodoApi.Infrastructure.Database;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}