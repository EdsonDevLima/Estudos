using Microsoft.AspNetCore.Mvc;
using Nexa.Dtos;
using Nexa.UseCases;

namespace Nexa.Controllers
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