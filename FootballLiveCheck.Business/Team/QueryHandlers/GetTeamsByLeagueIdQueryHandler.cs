using System.Collections.Generic;
using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Business.Team.QueryResults;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.Team.QueryHandlers
{
    public class GetTeamsByLeagueIdQueryHandler : DatabaseHandler, IQueryHandler<GetTeamsByLeagueIdQuery, GetTeamsByLeagueIdQueryResult>
    {
        private readonly ITeamRepository teamRepository;

        public GetTeamsByLeagueIdQueryHandler(IMapper mapper, ITeamRepository teamRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(teamRepository);
            EnsureArg.IsNotNull(mapper);
            this.teamRepository = teamRepository;
        }

        public GetTeamsByLeagueIdQueryResult Retrieve(GetTeamsByLeagueIdQuery query)
        {
          
            EnsureArg.IsNotNull(query);
            var teams = teamRepository.GetTeamsByLeagueId(query.LeagueId);
            return new GetTeamsByLeagueIdQueryResult(Mapper.Map<IReadOnlyCollection<TeamModel>>(teams));
        }
    }
}
