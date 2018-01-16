using System.Collections.Generic;
using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.League.Queries;
using FootballLiveCheck.Business.League.QueryResults;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.League.QueryHandlers
{
    public class GetTopLeaguesQueryHandler : DatabaseHandler, IQueryHandler<GetTopLeaguesQuery, GetTopLeaguesQueryResult>
    {
        private readonly ILeagueRepository leagueRepository;

        public GetTopLeaguesQueryHandler(IMapper mapper, ILeagueRepository leagueRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(leagueRepository);
            this.leagueRepository = leagueRepository;
        }

        public GetTopLeaguesQueryResult Retrieve(GetTopLeaguesQuery query)
        {
            EnsureArg.IsNotNull(query);
            var leagues = leagueRepository.GetTopLeagues();
            var models = Mapper.Map<IReadOnlyCollection<LeagueModel>>(leagues);
            return new GetTopLeaguesQueryResult(models);
        }
    }
}