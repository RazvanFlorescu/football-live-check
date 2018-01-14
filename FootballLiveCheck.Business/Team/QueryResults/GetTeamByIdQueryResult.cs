using EnsureThat;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamByIdQueryResult : IQueryResult
    {
        public GetTeamByIdQueryResult(TeamModel team)
        {
            EnsureArg.IsNotNull(team);
            Team = team;
        }

        public TeamModel Team { get; }
    }
}