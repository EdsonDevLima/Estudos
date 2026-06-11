using TodoApi.Domain.Repositories;
using TodoApi.Entities;

namespace TodoApi.Infrastructure.Database.Repositories
{
    class UserRepository : IUserRepostory
    {
        public Task Create(UserEntity newUser)
        {
                var sql = @"
                
                ";
            try
            {
                
            }
            catch (Exception Error)
            {
                
                throw new Exception("Erro ao criar usuario: " + Error.Message);
            }
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> GetById(string uuid)
        {
            throw new NotImplementedException();
        }

        public Task Remove(string uuid)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}