using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain.Entities;
using WebApi.Contracts;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("get-users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = _userRepository.GetUsers();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }

        [HttpGet("get-user/{userId}")]
        public IActionResult GetUserById(int userId)
        {
            var users = _userRepository.GetUserById(userId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }

        [HttpPost("add-user")]
        public IActionResult AddNewUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _userRepository.AddNewUser(user);

            return Ok();
        }

        [HttpPut("update-user")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _userRepository.UpdateUser(user);

            return Ok();
        }

        [HttpDelete("delete/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            _userRepository.DeleteUser(userId);

            return Ok();
        }

    }

}
