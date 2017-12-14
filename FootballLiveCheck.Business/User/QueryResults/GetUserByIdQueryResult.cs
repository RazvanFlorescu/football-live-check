using System.Linq;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.User.QueryResults
{
    public class GetUserByIdQueryResult : IQueryResult
    {
        public IQueryable Users { get; }

        public GetUserByIdQueryResult(IQueryable teams)
        {
            Users = teams;
        }
    }
}