using Microsoft.AspNetCore.Mvc;
using TaskApi.Dtos.Mappings;
using TaskApi.Models;
using TaskApi.Repositories;

namespace TaskApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unit) 
        {
            _unitOfWork = unit;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers() 
        {
            var users = await _unitOfWork.UserRepository.GetAllAsync();
            return Ok(users.ToReponseList());
        }

        [HttpGet("{id:int}", Name = "GetUser")]
        public async Task<ActionResult<User>> GetUserById(int id) 
        {
            if (id <= 0) return BadRequest();

            var user = await _unitOfWork.UserRepository.GetAsync(u => u.Id == id);

            if (user == null || user.Id == 0) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user) 
        {
            if (user == null) return BadRequest();

            var userRepository = await _unitOfWork.UserRepository.CreateAsync(user);
            await _unitOfWork.CommitAsync();

            return CreatedAtRoute("GetUser", new { id = user.Id }, userRepository);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUser(int id) 
        {
            if (id <= 0) return BadRequest();

            var user = await _unitOfWork.UserRepository.GetAsync(u => u.Id == id);

            if (user == null) return NotFound();

            await _unitOfWork.UserRepository.SoftDeleteAsync(user);
            await _unitOfWork.CommitAsync();

            return NoContent();
        }
    }
}
