using FootballLiveCheck.CqrsCore.Queries;
using System;
using EnsureThat;

namespace FootballLiveCheck.Business.League.QueryResults
{
    public class GetLeagueByApiIdQuery : IQuery
    {
        public int ApiId { get; private set; }

        public GetLeagueByApiIdQuery(int apiId)
        {
            EnsureArg.IsNotNull(apiId);
            this.ApiId = apiId;
        }
    }
}
