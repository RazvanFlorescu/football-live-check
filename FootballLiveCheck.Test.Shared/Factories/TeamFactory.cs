using System;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Tests.Shared.Factories
{
    public static class TeamFactory
    {
        public static TeamModel GetModel(string fullName, string shortName,
            int apiId, string shirtUrl, Arena arena)
        {
            return new TeamModel
            {
                Name = fullName,
                ShortName = shortName,
                DbId = apiId,
                ShirtUrl = shirtUrl,
                Arena = ArenaFactory.GetModel(arena)
            };
        }

        public static TeamModel GetModel(Team team)
        {
            return new TeamModel
            {
                Name = team.Name,
                ShortName = team.ShortName,
                DbId = team.DbId,
                ShirtUrl = team.ShirtUrl,
                Arena = ArenaFactory.GetModel(team.Arena)
            };
        }

        public static Team GetEntity(string fullName, string shortName,
            int apiId, string shirtUrl, Arena arena)
        {
            return Team.Create(fullName, shortName,
                        apiId, shirtUrl,arena);
        }
       
       
    }
}