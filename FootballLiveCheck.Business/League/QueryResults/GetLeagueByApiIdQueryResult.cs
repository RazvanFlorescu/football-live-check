using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.League.QueryResults
{
    public class GetLeagueByApiIdQueryResult : IQueryResult
    {
        public GetLeagueByApiIdQueryResult(LeagueModel league)
        {
            EnsureArg.IsNotNull(league);
            League = league;
        }

        public LeagueModel League { get; }
    }
}