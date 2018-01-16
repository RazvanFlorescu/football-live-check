using System.Collections.Generic;
using EnsureThat;
using FootballLiveCheck.Business.Match.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Match.QueryResults
{
    public class GetFulltimeMatchesByLeagueIdQueryResult : IQueryResult
    {
        public GetFulltimeMatchesByLeagueIdQueryResult(IReadOnlyCollection<MatchModel> maches)
        {
            EnsureArg.IsNotNull(maches);
            Matches = maches;
        }

        public IReadOnlyCollection<MatchModel> Matches { get; }
    }
}