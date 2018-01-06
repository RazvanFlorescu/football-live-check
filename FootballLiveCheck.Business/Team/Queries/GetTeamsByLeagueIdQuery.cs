using FootballLiveCheck.CqrsCore.Queries;
using System;
using EnsureThat;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamsByLeagueIdQuery : IQuery
    {
        public int LeagueId { get; private set; }

        public GetTeamsByLeagueIdQuery(int leagueId)
        {
            EnsureArg.IsNotNull(leagueId);
            this.LeagueId = leagueId;
        }
    }
}
