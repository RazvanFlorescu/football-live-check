using System;
using System.Collections.Generic;
using System.Text;
using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.League.QueryResults
{
    public class GetTopLeaguesQueryResult : IQueryResult
    {
        public GetTopLeaguesQueryResult(IReadOnlyCollection<LeagueModel> leagues)
        {
            EnsureArg.IsNotNull(leagues);
            Leagues = leagues;
        }

        public IReadOnlyCollection<LeagueModel> Leagues { get; }
    }

}
