using LearnedTry.Interface;
using LearnedTry.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace LearnedTry.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
           _userRepository = userRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public IActionResult GetUsers()
        { 
            var users = _userRepository.GetUsers();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
                return Ok(users);
        }


    }

    
}
