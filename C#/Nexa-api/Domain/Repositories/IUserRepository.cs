using Nexa.Entities;

namespace Nexa.Domain.Repositories;

public interface IUserRepostory
{
    Task Create(UserEntity newUser);
    Task<bool> Update(UserEntity user);
    Task<List<UserEntity>> GetAll();
    Task<List<UserEntity>> GetById(string uuid);
    Task Remove(string uuid);
}