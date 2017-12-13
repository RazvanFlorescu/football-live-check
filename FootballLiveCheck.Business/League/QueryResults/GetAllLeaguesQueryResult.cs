using System.Collections.Generic;
using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.League.QueryResults
{
    public class GetAllLeaguesQueryResult : IQueryResult
    {
        public GetAllLeaguesQueryResult(IReadOnlyCollection<LeagueModel> leagues)
        {
            EnsureArg.IsNotNull(leagues);
            Leagues = leagues;
        }

        public IReadOnlyCollection<LeagueModel> Leagues { get; }
    }
    
}