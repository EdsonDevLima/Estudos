using TodoApi.Entities;

namespace TodoApi.Domain.Repositories;

public interface ITaskRepostory
{
    Task Create(TaskEntity newTask);
    Task<bool> Update(TaskEntity task);
    Task<List<TaskEntity>> GetAll();
    Task<List<TaskEntity>> GetByUser(UserEntity user);
    Task Remove(TaskEntity task);
}