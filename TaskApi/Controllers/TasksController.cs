using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Repositories;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController(ITaskRepository repository) 
        {
            _taskRepository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Task>> AllTasks() 
        {
            var tasks = _taskRepository.GetAllTasks();

            if (tasks is null)
                return NotFound();

            return Ok(tasks);
        }

        [HttpGet("{id:int}", Name = "ObterTask")]
        public ActionResult<Models.Task> TaskById(int id) 
        {
            var task = _taskRepository.GetTaskById(id);

            if (task is null)
                return NotFound();

            return Ok(task);
        }

        [HttpPost]
        public ActionResult AddTask(Models.Task task) 
        {
            if (task is null)
                return BadRequest();

            var newTask = _taskRepository.CreateTask(task);
            
            return CreatedAtRoute("ObterTask", new { Id = newTask.Id}, newTask);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Models.Task> AtualizaTask(int id, Models.Task task) 
        {
            if (id <= 0 || id != task.Id)
                return BadRequest();

            var updatedTask = _taskRepository.PutTask(task);

            return Ok(updatedTask);
                
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Models.Task> DeleteTask(int id)
        {
            var task = _taskRepository.GetTaskById(id);

            if (task == null || id <= 0)
                return NotFound($"Task of {id}, not found!");

            var deletedTask = _taskRepository.DeleteTaskById(id);

            return deletedTask;
        }
    }
}
