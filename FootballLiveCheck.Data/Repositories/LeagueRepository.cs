using System.Linq;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class LeagueRepository  : BaseApiRepository<League>, ILeagueRepository
    {
        public LeagueRepository(DatabaseContext dbContext) : base(dbContext)
        { }
    }
}