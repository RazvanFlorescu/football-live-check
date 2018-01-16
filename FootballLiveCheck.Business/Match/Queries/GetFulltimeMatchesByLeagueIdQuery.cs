using EnsureThat;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Match.Queries
{
    public class GetFulltimeMatchesByLeagueIdQuery : IQuery
    {
        public int Id { get; }

        public GetFulltimeMatchesByLeagueIdQuery(int id)
        {
            EnsureArg.IsNotNull(id);
            this.Id = id;
        }
    }
}