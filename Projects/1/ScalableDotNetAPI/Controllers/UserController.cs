using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ScalableDotNetAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ScalableDotNetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> _users = new List<User>
        {
            new User { Id = 1, Username = "john_doe" },
            new User { Id = 2, Username = "jane_doe" }
        };

        // 1. Get All Users
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_users);
        }

        // 2. Get User by ID
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        // 3. Create User
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            user.Id = _users.Max(u => u.Id) + 1;
            _users.Add(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // 4. Update User
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();

            user.Username = updatedUser.Username;
            return Ok(user);
        }

        // 5. Delete User
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();

            _users.Remove(user);
            return NoContent();
        }
    }
}
