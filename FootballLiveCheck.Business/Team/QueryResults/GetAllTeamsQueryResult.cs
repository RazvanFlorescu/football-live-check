using System.Linq;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetAllTeamsQueryResult : IQueryResult
    {
        public IQueryable Teams { get; private set; }

        public GetAllTeamsQueryResult(IQueryable teams)
        {
            Teams = teams;
        }
    }
}