using Nexa.Entities;

namespace Nexa.Domain.Repositories;

public interface ITaskRepostory
{
    Task<string> Create(TaskEntity newTask);
    Task<string> Update(TaskEntity task);
    Task<List<TaskEntity>> GetAll();
    Task<List<TaskEntity>> GetByUser(UserEntity user);
    Task<string> Remove(TaskEntity task);
}