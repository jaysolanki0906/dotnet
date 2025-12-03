using Microsoft.AspNetCore.Mvc;
namespace MyApp.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class LoginController:ControllerBase
    {
        private readonly AuthService _authService;
        public LoginController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(string email, string password)
        {
            if (!_authService.ValidateUser(email, password))
                return BadRequest("Invalid email or password.");
            return Ok("Login successful");
        }
    }
}