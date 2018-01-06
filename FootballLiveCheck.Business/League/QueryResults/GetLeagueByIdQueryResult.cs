using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.League.QueryResults
{
    public class GetLeagueByIdQueryResult : IQueryResult
    {
        public GetLeagueByIdQueryResult(LeagueModel league)
        {
            EnsureArg.IsNotNull(league);
            League = league;
        }

        public LeagueModel League { get; }
    }
}