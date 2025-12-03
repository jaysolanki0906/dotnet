using Microsoft.AspNetCore.Mvc;
namespace MyApp.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class PingController:ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("Pong");
        }
    }
}
