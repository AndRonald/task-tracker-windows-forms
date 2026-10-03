using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;
using TaskEntity = TaskApi.Models.Task;
namespace TaskApi.Dtos.Mappings
{
    public static class TaskDTOMappingExtensions
    {
        public static TaskEntity ToTaskEntity(this CreateTaskRequest createTaskRequest) 
        {
            if (createTaskRequest == null) return null;

            return new TaskEntity
            {
                Description = createTaskRequest.Description,
                Status = createTaskRequest.Status,
                CreatedAt = DateTime.UtcNow
            };
        }
        public static TaskResponse ToResponse(this TaskEntity task) 
        {
            if (task is null) return null;

            return new TaskResponse 
            {
                Id = task.Id,
                Description = task.Description,
                Status = task.Status,
                CreatedAt = task.CreatedAt
            };
        }
        public static IEnumerable<TaskResponse> ToResponseList(this IEnumerable<TaskEntity> tasks) 
        {
            if (tasks is null || !tasks.Any()) return new List<TaskResponse>();

            return tasks.Select(t => new TaskResponse
            {
                Id = t.Id,
                Description = t.Description,
                Status = t.Status,
                CreatedAt = t.CreatedAt
            });
        }
    }
}
