using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.User.Queries;
using FootballLiveCheck.Business.User.QueryResults;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.User.QueryHandlers
{
    public class GetUserByIdQueryHandler : DatabaseHandler, IQueryHandler<GetUserByIdQuery, GetUserByIdQueryResult>
    {
        private readonly IUserRepository userRepository;
        public GetUserByIdQueryHandler(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(userRepository);
            EnsureArg.IsNotNull(mapper);
            this.userRepository = userRepository;
        }

        public GetUserByIdQueryResult Retrieve(GetUserByIdQuery query)
        {
            EnsureArg.IsNotNull(query);
            return new GetUserByIdQueryResult(userRepository.Search(t => t.Id == query.Id));
        }
    }
}