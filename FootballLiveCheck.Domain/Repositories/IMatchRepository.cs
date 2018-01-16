using System.Collections.Generic;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Repositories
{
    public interface IMatchRepository : IBaseApiRepository<Match>
    {
       IReadOnlyCollection<Match> GetAllLiveMatches();
       //IReadOnlyCollection<Match> GetAllFullTimeMatches();
      // IReadOnlyCollection<Match> GetAllUpcomingMatches();
       IReadOnlyCollection<Match> GetFullTimeMatchesByLeagueId(int leagueId);
       IReadOnlyCollection<Match> GetUpcomingMatchesByLeagueId(int leagueId);
    }
}