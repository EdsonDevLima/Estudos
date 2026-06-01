using Microsoft.AspNetCore.Mvc;
using TodoApi.Domain.Repositories;
using TodoApi.Dtos;
using TodoApi.Entities;

namespace TodoApi.UseCases
{
    public class UserUseCases
    {

        private readonly IUserRepostory userRepository;
        public UserUseCases(IUserRepostory _userRepository)
        {
            this.userRepository = _userRepository;
        }

        public ResponseDto Create(IUserCreateDto data)
        {
            try
            {

                if(data.password == data.confirmPassword)
                {
                var newUser = new UserEntity(data.name,data.email,"user","user");                    
                }
                else
                {
                return new ResponseDto
                {
                    Code = 401,
                    Message = "Erro na confirmação de senha"
                };
                }


            }
            catch(Exception error)
            {
                
            }
        }


    }
}