using TodoApi.Domain.Repositories;
using TodoApi.Entities;

namespace TodoApi.Infrastructure.Database.Repositories;

public class TaskRepositories : ITaskRepostory
{
    public Task Create(TaskEntity newTask)
    {
        throw new NotImplementedException();
    }

    public Task<List<TaskEntity>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<TaskEntity>> GetByUser(UserEntity user)
    {
        throw new NotImplementedException();
    }

    public Task Remove(TaskEntity task)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(TaskEntity task)
    {
        throw new NotImplementedException();
    }
}