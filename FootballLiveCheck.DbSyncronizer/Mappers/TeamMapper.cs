using System;
using System.Collections.Generic;
using System.Text;
using EnsureThat;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Mappers
{
    public class TeamMapper
        : IJsonMapper<Team, JTeam>
    {
        private IJsonMapper<Arena, JArena> arenaMapper;

        public TeamMapper(IJsonMapper<Arena, JArena> arenaMapper)
        {
            EnsureArg.IsNotNull(arenaMapper);
            this.arenaMapper = arenaMapper;
        }

        public Team Map(JTeam model)
        {
            var arena = arenaMapper.Map(model.Arena);
            return Team.Create(model.Name, model.ShortName, model.DbId, model.ShirtUrl, arena);
        }
    }
}
