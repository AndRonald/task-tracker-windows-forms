using TaskApi.Models.Enums;

namespace TaskApi.Dtos
{
    public class UpdateTaskRequest
    {
        public string? Description { get; set; }
        public Status Status { get; set; } 
    }
}
