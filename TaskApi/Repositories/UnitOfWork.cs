using TaskApi.Context;

namespace TaskApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ITaskRepository? _taskRepository;
        private IUserRepository? _userRepository;
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

        public IUserRepository UserRepository 
        {
            get
            {
                return _userRepository ??= new UserRepository(taskContext);
            }
        }

        public async Task CommitAsync() 
        {
            await taskContext.SaveChangesAsync();
        }
    }
}
