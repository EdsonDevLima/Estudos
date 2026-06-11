using Microsoft.AspNetCore.Mvc;
using TodoApi.Dtos;
using TodoApi.UseCases;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController
    {
        
    private readonly UserUseCases userUseCases;

    public UserController(UserUseCases _userUseCases)
    {
            this.userUseCases = _userUseCases;
    }

    [HttpPost]
    [Route("/")]
    public async Task<ActionResult> Create(IUserCreateDto data)
        {
            var result = await this.userUseCases.Create(data);
            return result;
            
        }







    }
}