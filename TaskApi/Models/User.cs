using System.ComponentModel.DataAnnotations;
using TaskApi.Repositories;

namespace TaskApi.Models
{
    public class User : ISoftDeletable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool IsDeleted { get; set; }
        public string? DeletedByName { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Models.Task>? Tasks { get; set; } = new List<Models.Task>();
    }
}
