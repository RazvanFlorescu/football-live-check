using FootballLiveCheck.CqrsCore.Queries;
using System;
using EnsureThat;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamsByLeagueIdQuery : IQuery
    {
        public Guid LeagueId { get; private set; }

        public GetTeamsByLeagueIdQuery(Guid leagueId)
        {
            EnsureArg.IsNotNull(leagueId);
            this.LeagueId = leagueId;
        }
    }
}
