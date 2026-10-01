using TaskApi.Repositories.Generic;
using TaskEntity = TaskApi.Models.Task;

namespace TaskApi.Repositories
{
    public interface ITaskRepository : IRepository<TaskEntity>
    {
    }
}
