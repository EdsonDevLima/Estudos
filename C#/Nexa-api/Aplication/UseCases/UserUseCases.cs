using Nexa.Domain.Repositories;
using Nexa.Dtos;
using Nexa.Entities;

namespace Nexa.UseCases
{
    public class UserUseCases
    {

        private readonly IUserRepostory userRepository;
        public UserUseCases(IUserRepostory _userRepository)
        {
            this.userRepository = _userRepository;
        }

        public async Task<ResponseDto> Create(IUserCreateDto data)
        {
            try
            {

                if(data.password == data.confirmPassword)
                {
                var newUser = new UserEntity(data.name,data.email,"user","user");  

                    await this.userRepository.Create(newUser);   

                var response = new ResponseDto{
                    code = 201,
                    message = "Usuario criado com sucesso"
                };

                return response;

                }
                else
                {
                var response = new ResponseDto{
                    code = 401,
                    message = "Erro na confirmação de senha"
                };
                return response;

                }


            }
            catch(Exception error)
            {
                var response = new ResponseDto{
                    code = 500,
                    message = error.Message
                };
                return response;   
            }
        }
        public async Task<ResponseDto> Remove(string uuid)
        {
            try
            {
                var data = await this.userRepository.GetById(uuid);
                
                if(data.Count > 0)
                {

                await this.userRepository.Remove(uuid);
                var response = new ResponseDto{
                    code = 206,
                    message = "Usuario removido"
                };
                return response;
                }
                else
                {
                var response = new ResponseDto{
                    code = 401,
                    message = "Erro na confirmação de senha"
                };
                return response;
                }
            }
            catch (Exception error)
            {
                var response = new ResponseDto{
                    code = 500,
                    message = error.Message
                };
                return response;   
            }
        }
        public async Task<ResponseDtoWitchItems> Get(string uuid = "")
        {
            try
            {
                List<UserEntity> users = [];

                if (uuid == "")
                {
                    users = await this.userRepository.GetAll();
                }
                else
                {
                    users = await this.userRepository.GetById(uuid);
                }

                var response = new ResponseDtoWitchItems{
                    code = 201,
                    message = "Sucesso",
                    items = users.Cast<object>().ToList()
            };
                return response;

            }
            catch (Exception error)
            {
            var response = new ResponseDtoWitchItems{
                    code = 500,
                    message = error.Message
            };
            return response;  
            }
        }

    }
}