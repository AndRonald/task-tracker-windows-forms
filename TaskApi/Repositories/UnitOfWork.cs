using TaskApi.Context;

namespace TaskApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ITaskRepository? _taskRepository;
        public TaskDbContext taskContext;

        public UnitOfWork(TaskDbContext context) 
        {
            this.taskContext = context;
        }

        public ITaskRepository TaskRepository
        {
            get
            {
                return _taskRepository ??= new TaskRepository(taskContext);
            }
        }

        public async Task Commit() 
        {
            await taskContext.SaveChangesAsync();
        }
    }
}
