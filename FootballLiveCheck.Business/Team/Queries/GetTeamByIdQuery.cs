using FootballLiveCheck.CqrsCore.Queries;
using System;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamByIdQuery : IQuery
    {
        public Guid Id { get; }

        public GetTeamByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}