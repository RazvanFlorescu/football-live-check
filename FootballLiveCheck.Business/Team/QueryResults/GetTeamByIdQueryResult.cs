using FootballLiveCheck.CqrsCore.Queries;
using System.Linq;
using EnsureThat;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamByIdQueryResult : IQueryResult
    {
        public TeamModel Team { get; private set; }

        public GetTeamByIdQueryResult(TeamModel team)
        {
            EnsureArg.IsNotNull(team);
            Team = team;
        }
    }
}
