using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Login.DTOs;
using WebApi_Login.Services;

namespace WebApi_Login.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public IActionResult Register(UserRegisterDto dto)
        {
            var result = _service.Register(dto);
            return Ok(result);
        }

        [HttpPost("login")]
        public IActionResult Login(UserLoginDto dto)
        {
            var result = _service.Login(dto);
            return Ok(result);
        }
        [Authorize]
        [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            var username = User.Identity.Name;
            return Ok("Welcome " + username);
        }
    }
}
