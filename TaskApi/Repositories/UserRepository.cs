using TaskApi.Context;
using TaskApi.Models;
using TaskApi.Repositories.Generic;

namespace TaskApi.Repositories
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public UserRepository(TaskDbContext context) : base(context) 
        {
        } 
    }
}
