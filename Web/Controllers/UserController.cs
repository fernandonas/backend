using Application.Models.UserModel;
using Application.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> GetUser() {
            var users = await _userService.GetUsers();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] UserRequestDTO userRequest)
        {
            var users = await _userService.AddUser(userRequest);
            return Ok(users);
        }
    }
}
