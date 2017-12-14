using System.Collections.Generic;
using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.User.Models;
using FootballLiveCheck.Business.User.Queries;
using FootballLiveCheck.Business.User.QueryResults;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.User.QueryHandlers
{
    public class GetAllUsersQueryHandler : DatabaseHandler, IQueryHandler<GetAllUsersQuery, GetAllUsersQueryResult>
    {
        private readonly IUserRepository userRepository;

        public GetAllUsersQueryHandler(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(userRepository);
            this.userRepository = userRepository;
        }

        public GetAllUsersQueryResult Retrieve(GetAllUsersQuery query)
        {
            EnsureArg.IsNotNull(query);
            var users = userRepository.GetAll();
            var models = Mapper.Map<IReadOnlyCollection<UserModel>>(users);
            return new GetAllUsersQueryResult(models);
        }
    }
}