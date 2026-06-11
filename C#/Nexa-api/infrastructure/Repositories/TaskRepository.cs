using Nexa.Domain.Repositories;
using Nexa.Entities;
using Dapper;

namespace Nexa.Infrastructure.Database.Repositories;

public class TaskRepositories : ITaskRepostory
{
    private readonly IDbConnectionFactory _connection;
    public TaskRepositories(IDbConnectionFactory connection)
    {
        this._connection = connection;
    }
    public async Task<string> Create(TaskEntity newTask)
    {
        var sql = @"
        INSERT INTO Task(Tittle,Description,UserId,Status,CompletedAt
        VALUES (@Tittle,@Description,@UserId,@Status,@CompletedAt));
        ";
        try
        {
            var connection =  _connection.CreateConnection();
            await connection.ExecuteAsync(sql,newTask);
            return "Task criada com sucesso";
        }
        catch(Exception Error)
        {
            throw new Exception("Erro ao criar task: " + Error.Message);
            
        }
    }

    public async Task<List<TaskEntity>> GetAll()
    {
        var sql = @"SELECT * FROM Task";
        try
        {
           var connection = this._connection.CreateConnection();

           var tasks = await connection.QueryAsync<TaskEntity>(sql);

           return tasks.ToList();
        }
        catch (Exception Error)
        {
            throw new Exception("Erro ao buscar Tasks:" + Error.Message);
        }
    }

    public async Task<List<TaskEntity>> GetByUser(UserEntity user)
    {
        var sql = @"SELECT * FROM Task WHERE Id = @Id";
        try
        {
           var connection = this._connection.CreateConnection();

           var tasks = await connection.QueryAsync<TaskEntity>(sql,user);

           return tasks.ToList();
        }
        catch (Exception Error)
        {
            throw new Exception("Erro ao buscar Tasks:" + Error.Message);
        }
    }

    public async Task<string> Remove(TaskEntity task)
    {
        var sql = @"DELETE FROM Task WHERE Id = @Id";
        try
        {
        var connection = _connection.CreateConnection();
        await connection.QueryAsync<TaskEntity>(sql,task);
        return "Task Removida";
        }
        catch (Exception Error)
        {
        throw new Exception("Erro ao remover Task:" + Error);
        }
    }

    public async Task<string> Update(TaskEntity task)
    {
        var sql = @"
        UPDATE Task
        SET Tittle = @Tittle,
        Description = @Descrition,
        UserId = @UserId,
        Status = @Status,
        CompletedAt = @CompletedAt";

        try
        {
            var connection = this._connection.CreateConnection();

            await connection.QueryAsync(sql,task);

            return "Task atualizada";
        }
        catch(Exception Error)
        {
            throw new Exception("Erro ao atualizar task: " + Error);
        }
    }
}