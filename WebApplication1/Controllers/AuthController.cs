using ApiContracts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DNP_Assignment.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private static readonly List<UserDTO> Users = new()
        {
            new UserDTO { Id = 1, UserName = "admin" },
            new UserDTO { Id = 2, UserName = "user" }
        };

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = Users.FirstOrDefault(u => u.UserName == request.UserName);
            
            if (user == null || request.Password != "password") 
            {
                return Unauthorized("Invalid username or password.");
            }

            return Ok(user);
        }
    }
}