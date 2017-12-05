using FootballLiveCheck.CqrsCore.Queries;
using System.Linq;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamByIdQueryResult : IQueryResult
    {
        public IQueryable Teams { get; private set; }

        public GetTeamByIdQueryResult(IQueryable teams)
        {
            Teams = teams;
        }
    }
}
