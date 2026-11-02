using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaskApi.Models;
using TaskEntity = TaskApi.Models.Task;

namespace TaskApi.Context
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) 
        {
        }

        public DbSet<TaskEntity> Tasks { get; set; } 
        public DbSet<User> User { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
