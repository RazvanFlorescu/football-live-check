using System.Collections.Generic;
using EnsureThat;
using FootballLiveCheck.Business.User.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.User.QueryResults
{
    public class GetAllUsersQueryResult : IQueryResult
    {
        public GetAllUsersQueryResult(IReadOnlyCollection<UserModel> users)
        {
            EnsureArg.IsNotNull(users);
            Users = users;
        }

        public IReadOnlyCollection<UserModel> Users { get; }
    }
}