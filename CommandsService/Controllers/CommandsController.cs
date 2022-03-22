using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers 
{
    [Route("api/c/platforms/{platformId}/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        public CommandsController()
        {

        }        
    }
}