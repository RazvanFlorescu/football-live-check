using FootballLiveCheck.CqrsCore.Queries;
using System;
using EnsureThat;

namespace FootballLiveCheck.Business.League.QueryResults
{
    public class GetLeagueByIdQuery : IQuery
    {
        public int Id { get; }

        public GetLeagueByIdQuery(int id)
        {
            EnsureArg.IsNotNull(id);
            this.Id = id;
        }
    }
}
