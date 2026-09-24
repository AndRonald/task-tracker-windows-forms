using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Context;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly TaskDbContext _taskDbContext;

        public TasksController(TaskDbContext context) 
        {
            _taskDbContext = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Task>> GetAllTasks() 
        {
            var tasks = _taskDbContext?.Tasks?.ToList();

            if (tasks?.Count <= 0)
                return NotFound();

            return Ok(tasks);
        }

        [HttpGet("{id:int}", Name = "ObterTask")]
        public ActionResult<Models.Task> TaskById(int id) 
        {
            if (id <= 0)
                return NotFound($"Task of id {id}, not found!");

            var task = _taskDbContext?.Tasks?.Find(id);

            if (task == null)
                return NotFound($"Task of id {id}, not found!");

            return Ok(task);
        }

        [HttpPost]
        public ActionResult AddTask(Models.Task task) 
        {
            if (task is null)
                return BadRequest();

            _taskDbContext?.Tasks?.Add(task);
            _taskDbContext?.SaveChanges();
            
            return CreatedAtRoute("ObterTask", new { Id = task.Id}, task);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Models.Task> AtualizaTask(int id, Models.Task task) 
        {
            if (id <= 0 || id != task.Id)
                return BadRequest();

            _taskDbContext.Entry(task).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _taskDbContext.SaveChanges();

            return Ok(task);
                
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Models.Task> DeleteTask(int id)
        {
            var task = _taskDbContext?.Tasks?.FirstOrDefault(t => t.Id == id);

            if (task == null || id <= 0)
                return NotFound($"Task of {id}, not found!");

            _taskDbContext?.Tasks?.Remove(task);
            _taskDbContext?.SaveChanges();

            return task;
        }
    }
}
