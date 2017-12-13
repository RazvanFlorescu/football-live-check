using System;
using System.Linq;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Team> GetTeamsByLeagueId(Guid leagueId)
        {
            return entitiesSet.Where(e => e.LeagueId == leagueId).AsQueryable();
        }
    }
}