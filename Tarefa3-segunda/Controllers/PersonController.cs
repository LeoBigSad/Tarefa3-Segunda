using Microsoft.AspNetCore.Mvc;
using Tarefa3.Domain.Interfaces.Service;

namespace Tarefa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController(IPersonService _personService) : ControllerBase
    {

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _personService.GetAll());
        }
    }
}