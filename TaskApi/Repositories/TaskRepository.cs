using Microsoft.AspNetCore.Http.HttpResults;
using TaskApi.Context;

namespace TaskApi.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskDbContext _taskDbContext;

        public TaskRepository(TaskDbContext context) 
        {
            _taskDbContext = context;
        }

        public IEnumerable<Models.Task> GetAllTasks() 
        {
            return _taskDbContext?.Tasks?.ToList() ?? new List<Models.Task>();
        }

        public Models.Task GetTaskById(int id) 
        {
            return _taskDbContext?.Tasks?.FirstOrDefault(t => t.Id == id) ?? new Models.Task();
        }

        public Models.Task CreateTask(Models.Task task)
        {
            if (task is null)
                throw new ArgumentNullException(nameof(Models.Task));

            _taskDbContext?.Tasks?.Add(task);
            _taskDbContext?.SaveChanges();

            return task;
        }

        public Models.Task PutTask(Models.Task task) 
        {
            if (task is null)
                throw new ArgumentNullException(nameof(Models.Task));

            _taskDbContext.Entry(task).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _taskDbContext.SaveChanges();

            return task;
        }
        public Models.Task DeleteTaskById(int id) 
        {
            var task = _taskDbContext?.Tasks?.Find(id);

            if (task is null)
                throw new ArgumentNullException(nameof(Models.Task));

            _taskDbContext?.Tasks?.Remove(task);
            _taskDbContext?.SaveChanges();

            return task;
        }
    }
}
