using System;
using System.Linq;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class TeamRepository : BaseApiRepository<Team>, ITeamRepository
    {
        public TeamRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Team> GetTeamsByLeagueId(int leagueId)
        {
            return entitiesSet.Where(e => e.Id == leagueId).AsQueryable();
        }
    }
}