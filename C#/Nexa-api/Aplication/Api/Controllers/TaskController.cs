using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Nexa.Dtos;
using Nexa.UseCases;

namespace Nexa.Controllers
{
    [ApiController]
    [Route("task")]
    public class TaskController:ControllerBase
    {
        
    private readonly TaskUseCases TaskUseCases;

    public TaskController(TaskUseCases _TaskUseCases)
    {
            this.TaskUseCases = _TaskUseCases;
    }

    [HttpPost]
    [Route("/")]
    public async Task<ActionResult> Create(ITaskCreateDto data)
        {
            try
            {
            var result = await this.TaskUseCases.Create(data);

            return Ok(result);

               
            }catch(Exception error)
            {
                return StatusCode(500,error.Message);
            }
            
        }
        [HttpGet]
        [Route("all")]
        public async Task<ActionResult> GetAll(ITaskCreateDto data)
        {
            try
            {
            var result = await this.TaskUseCases.Get();

            return Ok(result);

               
            }catch(Exception error)
            {
                return StatusCode(500,error.Message);
            }
            
        }
        [HttpGet]
        [Route(":id")]
        public async Task<ActionResult> GetAll(string id)
        {
            try
            {
            var result = await this.TaskUseCases.Get(id);

            return Ok(result);

               
            }catch(Exception error)
            {
                return StatusCode(500,error.Message);
            }
            
        }
    }
}