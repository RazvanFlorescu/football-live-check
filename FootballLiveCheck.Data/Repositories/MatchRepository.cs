using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Data.Repositories
{
    public class MatchRepository :BaseApiRepository<Match>
    {
        public MatchRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}