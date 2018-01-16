using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class ArenaRepository : BaseApiRepository<Arena>, IArenaRepository
    {
        public ArenaRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}