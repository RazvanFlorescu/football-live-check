using FootballLiveCheck.CqrsCore.Queries;
using System;
using EnsureThat;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetTeamByIdQuery: IQuery
    {
        public int Id { get; }

        public GetTeamByIdQuery(int id)
        {
            EnsureArg.IsNotNull(id);
            this.Id = id;
        }
    }
}
