using Dapper;

namespace TodoApi.Infrastructure.Database;

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
        IF NOT EXIST (SELECT * FROM sys.tables WHERE name = 'Users')
        BENGIN
            CREATE TABLE Users(
                Id UNIQUEIINDETIFIER NOT NULL PRIMARY KEY,
                Name NVARCHAR(100) NOT NULL,
                Position NVARCHAR(100) NOT NULL,
                Email NVARCHAR(100) NOT NULL,
                Password NVARCHAR(250) NOT NULL,
                Role NVARCHAR(50) NOT NULL,
            );
        END;
        IF NOT EXIST (SELECT * FROM sys.tables WHERE name = 'Tasks')
        BENGIN
            CREATE TABLE Tasks(
            Id UNIQUEIINDETIFIER NOT NULL PRIMARY KEY,
            Tittle NVARCHAR(100) NOT NULL,
            Status NVARCHAR(50) NOT NULL,
            Description NVARCHAR NOT NULL,
            UserID UNIQUEIDENTIFIER NOT NULL,
            CreateAt DATETIME2 NOT NULL,
            CompletedAt DATETIME2 NOT NULL
            CONSTRAINT FK_Tasks_Users
            FOREIGN KEY (UserId) REFERENCES Users(Id)
            );
        END;
        ";
        using var connection = _connectionFactory.CreateConnection();
        await connection.ExecuteAsync(sql);

        
        }
}