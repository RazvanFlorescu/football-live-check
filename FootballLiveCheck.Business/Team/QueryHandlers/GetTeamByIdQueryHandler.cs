using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Team.QueryResults;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.Team.QueryHandlers
{
    public class GetTeamByIdQueryHandler : DatabaseHandler, IQueryHandler<GetTeamByIdQuery, GetTeamByIdQueryResult>
    {
        private readonly ITeamRepository teamRepository;

        public GetTeamByIdQueryHandler(IMapper mapper, ITeamRepository teamRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(teamRepository);
            EnsureArg.IsNotNull(mapper);
            this.teamRepository = teamRepository;
        }

        public GetTeamByIdQueryResult Retrieve(GetTeamByIdQuery query)
        {
            EnsureArg.IsNotNull(query);
            return new GetTeamByIdQueryResult(this.teamRepository.Search(t => t.Id == query.Id));
        }
    }
}
