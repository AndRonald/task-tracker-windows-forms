using TaskApi.Context;

namespace TaskApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ITaskRepository _taskRepository;
        public TaskDbContext taskContext;

        public UnitOfWork(TaskDbContext context) 
        {
            this.taskContext = context;
        }

        public ITaskRepository TaskRepository
        {
            get
            {
                return _taskRepository ?? new TaskRepository(this.taskContext);
            }
        }

        public void Commit() 
        {
            this.taskContext.SaveChangesAsync();
        }

        public void Dispose() 
        {
            this.taskContext.Dispose();
        }

    }
}
