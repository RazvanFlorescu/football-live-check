using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.League.QueryResults;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.League.QueryHandlers
{
    public class GetLeagueByIdQueryHandler : DatabaseHandler, IQueryHandler<GetLeagueByIdQuery, GetLeagueByIdQueryResult>
    {
        private readonly ILeagueRepository leagueRepository;

        public GetLeagueByIdQueryHandler(IMapper mapper, ILeagueRepository leagueRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(leagueRepository);
            EnsureArg.IsNotNull(mapper);
            this.leagueRepository = leagueRepository;
        }

        public GetLeagueByIdQueryResult Retrieve(GetLeagueByIdQuery query)
        {
            EnsureArg.IsNotNull(query);
            return new GetLeagueByIdQueryResult(Mapper.Map<LeagueModel>(this.leagueRepository.GetById(query.Id)));
        }
    }
}
