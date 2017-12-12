using System;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Tests.Shared.Factories
{
    public static class TeamFactory
    {
        public static TeamModel GetModel(string name, Guid leagueId, int points)
        {
            return new TeamModel
            {
                Name = name,
                LeagueId = leagueId,
                Points = points
            };
        }

        public static TeamModel GetModel(Team team)
        {
            return new TeamModel
            {
                Id = team.Id,
                Name = team.Name,
                LeagueId = team.LeagueId,
                Points = team.Points
            };
        }

        public static Team GetEntity(string name, Guid leagueId, int points)
        {
            return Team.Create(name, leagueId, points);
        }
    }
}