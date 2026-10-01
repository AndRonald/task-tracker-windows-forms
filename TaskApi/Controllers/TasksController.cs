using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Repositories;
using TaskApi.Repositories.Generic;
using TaskEntity = TaskApi.Models.Task;

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
        public async Task<ActionResult<IEnumerable<TaskEntity>>> AllTasks() 
        {
            var tasks = await _unitOfWork.TaskRepository.GetAllAsync();

            if (tasks is null)
                return NotFound("Tasks not found!");

            return Ok(tasks);
        }

        [HttpGet("{id:int}", Name = "ObterTask")]
        public async Task<ActionResult<TaskEntity>> TaskById(int id) 
        {
            var task = await _unitOfWork.TaskRepository.GetAsync(p => p.Id == id);

            if (task is null)
                return NotFound($"Task {id}, not found!");

            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult> AddTask(TaskEntity task) 
        {
            if (task is null)
                return BadRequest();

            var newTask = await _unitOfWork.TaskRepository.CreateAsync(task);
            _unitOfWork.Commit();
            
            return CreatedAtRoute("ObterTask", new { Id = newTask.Id}, newTask);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<TaskEntity>> AtualizaTask(int id, TaskEntity task) 
        {
            if (id <= 0 || id != task.Id)
                return BadRequest("incompatible ids");

            var updatedTask = await _unitOfWork.TaskRepository.UpdateAsync(task);
            _unitOfWork.Commit();

            return Ok(updatedTask);
                
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<TaskEntity>> DeleteTask(int id)
        {
            if (id <= 0)
                return BadRequest($"Invalid task id.");

            var task = await _unitOfWork.TaskRepository.GetAsync(p => p.Id == id);

            if (task == null)
                return NotFound($"Task {id}, not found!");

            var deletedTask = await _unitOfWork.TaskRepository.SoftDeleteAsync(task);
            _unitOfWork.Commit();

            return deletedTask;
        }
    }
}
