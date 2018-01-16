using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.Match.Models;
using FootballLiveCheck.Business.Match.Queries;
using FootballLiveCheck.Business.Match.QueryResults;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.Match.QueryHandlers
{
    public class GetUpcomingMatchesByLeagueIdQueryHandler : DatabaseHandler,
        IQueryHandler<GetUpcomingMatchesByLeagueIdQuery, GetUpcomingMatchesByLeagueIdQueryResult>
    {
        private readonly IArenaRepository arenaRepository;
        private readonly ILeagueRepository leagueRepository;
        private readonly IMatchRepository matchRepository;
        private readonly ITeamRepository teamRepository;

        public GetUpcomingMatchesByLeagueIdQueryHandler(IMapper mapper, IMatchRepository matchRepository,
            ITeamRepository teamRepository,
            ILeagueRepository leagueRepository, IArenaRepository arenaRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(matchRepository);
            EnsureArg.IsNotNull(teamRepository);
            EnsureArg.IsNotNull(leagueRepository);
            EnsureArg.IsNotNull(arenaRepository);
            this.matchRepository = matchRepository;
            this.teamRepository = teamRepository;
            this.leagueRepository = leagueRepository;
            this.arenaRepository = arenaRepository;
        }

        public GetUpcomingMatchesByLeagueIdQueryResult Retrieve(GetUpcomingMatchesByLeagueIdQuery query)
        {
            EnsureArg.IsNotNull(query);
            var matches = matchRepository.GetUpcomingMatchesByLeagueId(query.Id);
            var models = Mapper.Map<IReadOnlyCollection<MatchModel>>(matches);
            foreach (var m in matches)
            {
                //var model = models.Where(mo => mo.DbId == m.DbId);
                var homeTeam = Mapper.Map<TeamModel>(teamRepository.GetById(m.HomeTeamId));
                var awayTeam = Mapper.Map<TeamModel>(teamRepository.GetById(m.AwayTeamId));
                var league = Mapper.Map<LeagueModel>(leagueRepository.GetById(m.LeagueId));

                if (m.ArenaId.HasValue)
                {
                    var arena = Mapper.Map<ArenaModel>(arenaRepository.GetById(m.ArenaId.Value));
                    models.Where(mo => mo.DbId == m.DbId).FirstOrDefault().Arena = arena;
                }


                models.Where(mo => mo.DbId == m.DbId).FirstOrDefault().HomeTeam = homeTeam;
                models.Where(mo => mo.DbId == m.DbId).FirstOrDefault().AwayTeam = awayTeam;
                models.Where(mo => mo.DbId == m.DbId).FirstOrDefault().League = league;
            }
            return new GetUpcomingMatchesByLeagueIdQueryResult(models);
        }
    }
}