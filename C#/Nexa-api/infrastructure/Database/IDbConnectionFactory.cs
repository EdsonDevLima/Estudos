using System.Data;

namespace Nexa.Infrastructure.Database;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}