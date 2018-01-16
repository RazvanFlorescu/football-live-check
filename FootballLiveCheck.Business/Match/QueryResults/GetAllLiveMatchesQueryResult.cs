using System.Collections.Generic;
using EnsureThat;
using FootballLiveCheck.Business.Match.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Match.QueryResults
{
    public class GetAllLiveMatchesQueryResult : IQueryResult
    {
        public GetAllLiveMatchesQueryResult(IReadOnlyCollection<MatchModel> matches)
        {
            EnsureArg.IsNotNull(matches);
            Matches = matches;
        }

        public IReadOnlyCollection<MatchModel> Matches { get; }
    }
}