using System;
using System.Linq;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Repositories
{
    public interface ITeamRepository : IBaseRepository<Team>
    {
        IQueryable<Team> GetTeamsByLeagueId(Guid leagueId);
    }
}