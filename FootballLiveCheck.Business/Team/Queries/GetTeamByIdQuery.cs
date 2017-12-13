using FootballLiveCheck.CqrsCore.Queries;
using System;
using EnsureThat;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamByIdQuery: IQuery
    {
        public Guid Id { get; private set; }

        public GetTeamByIdQuery(Guid id)
        {
            EnsureArg.IsNotNull(id);
            this.Id = id;
        }
    }
}
