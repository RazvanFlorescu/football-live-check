using System.Collections.Generic;
using EnsureThat;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamsByLeagueIdQueryResult : IQueryResult
    {
        public GetTeamsByLeagueIdQueryResult(IReadOnlyCollection<TeamModel> teams)
        {
            EnsureArg.IsNotNull(teams);
            Teams = teams;
        }

        public IReadOnlyCollection<TeamModel> Teams { get; }
    }
}