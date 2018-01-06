using System;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Tests.Shared.Factories
{
    public static class TeamFactory
    {
        public static TeamModel GetModel(string fullName, string shortName,
            int apiId, string shirtUrl)
        {
            return new TeamModel
            {
                FullName = fullName,
                ShortName = shortName,
                ApiId = apiId,
                ShirtUrl = shirtUrl,
                //ArenaCapacity = arenaCapacity,
                //ArenaId = arenaId,
                //ArenaName = arenaName
            };
        }

        public static TeamModel GetModel(Team team)
        {
            return new TeamModel
            {
                FullName = team.FullName,
                ShortName = team.ShortName,
                ApiId = team.ApiId,
                ShirtUrl = team.ShirtUrl,
                //ArenaCapacity = team.ArenaCapacity,
                //ArenaId = team.ArenaId,
                //ArenaName = team.ArenaName
            };
        }

        public static Team GetEntity(string fullName, string shortName,
            int apiId, string shirtUrl, int arenaId, int arenaCapacity, string arenaName)
        {
            return Team.Create(fullName, shortName,
                        apiId, shirtUrl);
        }
       
       
    }
}