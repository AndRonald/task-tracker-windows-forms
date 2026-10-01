namespace TaskApi.Repositories
{
    public interface IUnitOfWork
    {
        ITaskRepository TaskRepository { get; }
        void Commit();
    }
}
