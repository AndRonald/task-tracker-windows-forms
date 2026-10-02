namespace TaskApi.Repositories
{
    public interface IUnitOfWork
    {
        ITaskRepository TaskRepository { get; }
        Task Commit();
    }
}
