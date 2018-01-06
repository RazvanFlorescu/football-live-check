using System;
using System.Linq;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Repositories
{
    public interface ITeamRepository : IBaseApiRepository<Team>
    {
        IQueryable<Team> GetTeamsByLeagueId(int leagueId);
    }
}