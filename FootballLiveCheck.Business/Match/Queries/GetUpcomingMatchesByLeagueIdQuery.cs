using EnsureThat;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Match.Queries
{
    public class GetUpcomingMatchesByLeagueIdQuery :IQuery
    {
        public int Id { get; }

        public GetUpcomingMatchesByLeagueIdQuery(int id)
        {
            EnsureArg.IsNotNull(id);
            this.Id = id;
        }
    }
}