using Microsoft.AspNetCore.Mvc;
using TaskApi.Dtos;
using TaskApi.Dtos.Mappings;
using TaskApi.Repositories;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TasksController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskResponse>>> AllTasks() 
        {
            var tasks = await _unitOfWork.TaskRepository.GetAllAsync();
            return Ok(tasks.ToResponseList());
        }

        [HttpGet("{id:int}", Name = "GetTask")]
        public async Task<ActionResult<TaskResponse>> TaskById(int id) 
        {
            var task = await _unitOfWork.TaskRepository.GetAsync(p => p.Id == id);

            if (task is null)
                return NotFound($"Task {id}, not found!");

            return Ok(task.ToResponse());
        }

        [HttpPost]
        public async Task<ActionResult<TaskResponse>> AddTask(CreateTaskRequest taskRequest) 
        {
            var newTask = await _unitOfWork.TaskRepository.CreateAsync(taskRequest.ToTaskEntity());
            await _unitOfWork.Commit();
            
            return CreatedAtRoute("GetTask", new { id = newTask.Id }, newTask.ToResponse());
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<TaskResponse>> UpdateTask(int id, UpdateTaskRequest taskRequest) 
        {
            if (id <= 0)
                return BadRequest("Invalid task id");

            var task = await _unitOfWork.TaskRepository.GetAsync(t => t.Id == id);

            if (task is null)
                return NotFound($"Task {id} not found");

            task.Description = taskRequest.Description;
            task.Status = taskRequest.Status;
            task.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.Commit();
            return Ok(task.ToResponse());
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteTask(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid task id.");

            var task = await _unitOfWork.TaskRepository.GetAsync(p => p.Id == id);

            if (task == null)
                return NotFound($"Task {id}, not found!");

            await _unitOfWork.TaskRepository.SoftDeleteAsync(task);
            await _unitOfWork.Commit();

            return NoContent();
        }
    }
}
