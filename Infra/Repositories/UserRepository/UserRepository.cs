using Domain.Entity;
using Domain.Interfaces;
using Infra.Context;
using Infra.Repositories.GenericRepository;

namespace Infra.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(MainContext dbContext) : base(dbContext)
        {
        }
    }
}
