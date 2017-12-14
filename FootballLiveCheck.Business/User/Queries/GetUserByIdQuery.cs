using System;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.User.Queries
{
    public class GetUserByIdQuery : IQuery
    {
        public Guid Id { get; }

        public GetUserByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}