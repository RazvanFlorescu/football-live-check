using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.League.QueryResults;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.League.QueryHandlers
{
    public class GetLeagueByApiIdQueryHandler : DatabaseHandler, IQueryHandler<GetLeagueByApiIdQuery, GetLeagueByApiIdQueryResult>
    {
        private readonly ILeagueRepository leagueRepository;

        public GetLeagueByApiIdQueryHandler(IMapper mapper, ILeagueRepository leagueRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(leagueRepository);
            EnsureArg.IsNotNull(mapper);
            this.leagueRepository = leagueRepository;
        }

        public GetLeagueByApiIdQueryResult Retrieve(GetLeagueByApiIdQuery query)
        {
            EnsureArg.IsNotNull(query);
            return new GetLeagueByApiIdQueryResult(Mapper.Map<LeagueModel>(this.leagueRepository.GetById(query.ApiId)));
        }
    }
}
