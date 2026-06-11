using TodoApi.Domain.Repositories;
using TodoApi.Dtos;
using TodoApi.Entities;

namespace TodoApi.UseCases
{
    public class TaskUseCases
    {

        private readonly ITaskRepostory TaskRepository;
        private readonly IUserRepostory UserRepository;
        public TaskUseCases(ITaskRepostory _TaskRepository,IUserRepostory _UserRepository)
        {
            this.TaskRepository = _TaskRepository;
            this.UserRepository = _UserRepository;
        }

        public async Task<ResponseDto> Create(ITaskCreateDto data)
        {
            try
            {

                var user = await this.UserRepository.GetById(data.UserId.ToString());
                if(user.Count() > 0)
                {
                var newTask = new TaskEntity(data.Tittle,data.Status,data.Description,data.UserId,data.CompletedAt);  

                await this.TaskRepository.Create(newTask);   

                var response = new ResponseDto{
                    code = 201,
                    message = "Task criada com sucesso"
                };

                return response;
                }
                else
                {
                   var response = new ResponseDto{
                    code = 401,
                    message = "Usuario invalido ou sem permissão para a ação"
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
        public async Task<ResponseDto> Remove(string taskUuid,string userUuid)
        {
            try
            {
                var user = await this.UserRepository.GetById(userUuid);
                
                if(user.Count > 0)
                {

                var data = await  this.TaskRepository.GetByUser(user[0]);

                await this.TaskRepository.Remove(data.Find(t=>t.Id.ToString() == taskUuid));

                var response = new ResponseDto{
                    code = 206,
                    message = "Task removida"
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
                List<TaskEntity> Tasks = [];

                if (uuid == "")
                {
                    Tasks = await this.TaskRepository.GetAll();
                }
                else
                {
                    var data = await this.TaskRepository.GetAll();
                        Tasks = data
                        .Where(t => t.Id.ToString() == uuid)
                        .ToList(); 
                }

                var response = new ResponseDtoWitchItems{
                    code = 201,
                    message = "Sucesso",
                    items = Tasks.Cast<object>().ToList()
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