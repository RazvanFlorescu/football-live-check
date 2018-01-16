using System.Collections.Generic;
using System.Linq;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class MatchRepository : BaseApiRepository<Match>, IMatchRepository
    {
        public MatchRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
        
        public IReadOnlyCollection<Match> GetAllLiveMatches()
        {
            return entitiesSet.Where(m => m.CurrentState == 1 ||
                                                     m.CurrentState == 2 ||
                                                     m.CurrentState == 3 ||
                                                     m.CurrentState == 4 ||
                                                     m.CurrentState == 5 ||
                                                     m.CurrentState == 6 ||
                                                     m.CurrentState == 7 ||
                                                     m.CurrentState == 8).OrderBy(m => m.StartDate).ToList();   
        }

        public IReadOnlyCollection<Match> GetFullTimeMatchesByLeagueId(int leagueId)
        {
            return entitiesSet.Where(m => m.CurrentState == 9 && m.LeagueId == leagueId).OrderBy(m =>m.StartDate).ToList();
        }

        public IReadOnlyCollection<Match> GetUpcomingMatchesByLeagueId(int leagueId)
        {
            return entitiesSet.Where(m => m.CurrentState == 0 && m.LeagueId == leagueId).OrderBy(m => m.StartDate).ToList();
        }

       
        
    }
}