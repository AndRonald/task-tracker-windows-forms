using System.ComponentModel.DataAnnotations;
using TaskApi.Models.Enums;

namespace TaskApi.Models
{
    public class Task 
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
