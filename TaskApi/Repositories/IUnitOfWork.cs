namespace TaskApi.Repositories
{
    public interface IUnitOfWork
    {
        ITaskRepository TaskRepository { get; }
        IUserRepository UserRepository { get; }
        Task CommitAsync();
    }
}
