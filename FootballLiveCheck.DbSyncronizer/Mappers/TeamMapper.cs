using EnsureThat;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Mappers
{
    public class TeamMapper
        : IJsonMapper<Team, JTeam>
    {
        private readonly IJsonMapper<Arena, JArena> arenaMapper;

        public TeamMapper(IJsonMapper<Arena, JArena> arenaMapper)
        {
            EnsureArg.IsNotNull(arenaMapper);
            this.arenaMapper = arenaMapper;
        }

        public Team Map(JTeam model)
        {
            var arena = arenaMapper.Map(model.defaultHomeVenue);
            int? arenaId = arena != null ? arena.DbId : (int?) null;
            var team = Team.Create(model.Name, model.ShortName, model.DbId, model.ShirtUrl, arena);
            team.SetArenaId(arenaId);
            return team;
        }
    }
}