using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TaskApi.Models;

namespace TaskApi.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Models.Task>
    {
        public void Configure(EntityTypeBuilder<Models.Task> entity) 
        {
            entity.HasQueryFilter(t => !t.IsDeleted);

            entity.HasOne(u => u.User)
                  .WithMany(u => u.Tasks)
                  .HasForeignKey(u => u.UserId);
        }
    }
}
