using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class UserRepository : BaseRepository<User> , IUserRepository
    {
        public UserRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}