using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Team.Queries;
using FootballLiveCheck.Business.Team.QueryResults;
using FootballLiveCheck.Domain.Repositories;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Team.QueryHandlers
{
    public class GetAllTeamsQueryHandler : DatabaseHandler, IQueryHandler<GetAllTeamsQuery, GetAllTeamsQueryResult>
    {
        private readonly ITeamRepository teamRepository;

        public GetAllTeamsQueryHandler(IMapper mapper, ITeamRepository teamRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(teamRepository);
            this.teamRepository = teamRepository;
        }

        public GetAllTeamsQueryResult Retrieve(GetAllTeamsQuery query)
        {
            var result = teamRepository.GetAll();
            return new GetAllTeamsQueryResult(result);
        }
    }
}