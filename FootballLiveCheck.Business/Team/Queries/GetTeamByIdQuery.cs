using FootballLiveCheck.CqrsCore.Queries;
using System;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamByIdQuery: IQuery
    {
        public Guid Id { get; private set; }

        public GetTeamByIdQuery(Guid id)
        {
            this.Id = id;
        }
    }
}
