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
                FullName = fullName,
                ShortName = shortName,
                ApiId = apiId,
                ShirtUrl = shirtUrl,
                Arena = ArenaFactory.GetModel(arena)
            };
        }

        public static TeamModel GetModel(Team team)
        {
            return new TeamModel
            {
                FullName = team.Name,
                ShortName = team.ShortName,
                ApiId = team.DbId,
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