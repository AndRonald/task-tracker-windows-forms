using Microsoft.AspNetCore.Http.HttpResults;
using TaskApi.Context;
using TaskApi.Repositories.Generic;
using TaskEntity = TaskApi.Models.Task;

namespace TaskApi.Repositories
{
    public class TaskRepository : Repository<TaskEntity>, ITaskRepository
    {
        public TaskRepository(TaskDbContext context) : base(context) 
        {
        }
    }
}
