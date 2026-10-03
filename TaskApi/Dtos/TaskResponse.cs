using TaskApi.Models.Enums;

namespace TaskApi.Dtos
{
    public class TaskResponse
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
