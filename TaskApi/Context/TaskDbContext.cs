using Microsoft.EntityFrameworkCore;

namespace TaskApi.Context
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) 
        {
        }

        public DbSet<Models.Task>? Tasks { get; set; } 
    }
}
