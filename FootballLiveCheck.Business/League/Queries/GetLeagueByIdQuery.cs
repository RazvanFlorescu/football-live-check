using FootballLiveCheck.CqrsCore.Queries;
using System;
using EnsureThat;

namespace FootballLiveCheck.Business.League.QueryResults
{
    public class GetLeagueByIdQuery : IQuery
    {
        public Guid Id { get; private set; }

        public GetLeagueByIdQuery(Guid id)
        {
            EnsureArg.IsNotNull(id);
            this.Id = id;
        }
    }
}
