using System.ComponentModel.DataAnnotations;
using TaskApi.Models.Enums;

namespace TaskApi.Dtos
{
    public class UpdateTaskRequest
    {
        [Required]
        [StringLength(400, MinimumLength = 1, ErrorMessage ="Description must be between 1 and 400 characters")]
        public string? Description { get; set; }
        [Required]
        [EnumDataType(typeof(Status), ErrorMessage = "Invalid status")]
        public Status Status { get; set; } 
    }
}
