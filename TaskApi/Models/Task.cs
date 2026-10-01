using System.ComponentModel.DataAnnotations;
using TaskApi.Models.Enums;
using TaskApi.Repositories;

namespace TaskApi.Models
{
    public class Task : ISoftDeletable
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
        [Required]
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
