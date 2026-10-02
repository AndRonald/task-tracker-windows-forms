using Microsoft.EntityFrameworkCore;
using TaskEntity = TaskApi.Models.Task;

namespace TaskApi.Context
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) 
        {
        }

        public DbSet<Models.Task>? Tasks { get; set; } 
    
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<TaskEntity>(entity => entity.HasQueryFilter(e => !e.IsDeleted));
        }
    }
}
