using Dapper;

namespace Nexa.Infrastructure.Database;

public class DataInitializer
{
    public readonly IDbConnectionFactory _connectionFactory;

    public DataInitializer(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task InitializeAsync()
    {
        const string sql = @"
        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
        BEGIN
            CREATE TABLE Users(
                Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
                Name NVARCHAR(100) NOT NULL,
                Position NVARCHAR(100) NOT NULL,
                Email NVARCHAR(100) NOT NULL,
                Password NVARCHAR(250) NOT NULL,
                Role NVARCHAR(50) NOT NULL
            );
        END;

        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tasks')
        BEGIN
            CREATE TABLE Tasks(
                Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
                Title NVARCHAR(100) NOT NULL,
                Status NVARCHAR(50) NOT NULL,
                Description NVARCHAR(MAX) NOT NULL,
                UserId UNIQUEIDENTIFIER NOT NULL,
                CreatedAt DATETIME2 NOT NULL,
                CompletedAt DATETIME2 NULL,

                CONSTRAINT FK_Tasks_Users
                FOREIGN KEY (UserId) REFERENCES Users(Id)
            );
        END;
        ";
        using var connection = _connectionFactory.CreateConnection();
        await connection.ExecuteAsync(sql);

        
        }
}