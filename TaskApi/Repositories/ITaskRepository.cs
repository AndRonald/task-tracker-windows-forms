namespace TaskApi.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<Models.Task> GetAllTasks();
        Models.Task GetTaskById(int id);
        Models.Task CreateTask(Models.Task taks);
        Models.Task PutTask(Models.Task task);
        Models.Task DeleteTaskById(int id);
    }
}
