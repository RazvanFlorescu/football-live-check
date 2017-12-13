using System.Collections.Generic;
using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.League.Queries;
using FootballLiveCheck.Business.League.QueryResults;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.League.QueryHandlers
{
    public class GetAllLeaguesQueryHandler : DatabaseHandler,
        IQueryHandler<GetAllLeaguesQuery, GetAllLeaguesQueryResult>
    {
        private readonly ILeagueRepository leagueRepository;

        public GetAllLeaguesQueryHandler(IMapper mapper, ILeagueRepository leagueRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(leagueRepository);
            this.leagueRepository = leagueRepository;
        }

        public GetAllLeaguesQueryResult Retrieve(GetAllLeaguesQuery query)
        {
            EnsureArg.IsNotNull(query);
            var leagues = leagueRepository.GetAll();
            var models = Mapper.Map<IReadOnlyCollection<LeagueModel>>(leagues);
            return new GetAllLeaguesQueryResult(models);
        }
    }
}