using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Tests.Shared.Factories
{
    public static class LeagueFactory
    {
        public static League GetEntity(int apiId, string shortName, string fullName, string flagURL,
            Region region)
        {
            return League.Create(apiId, shortName, fullName, flagURL, region);
        }

        public static LeagueModel GetModel(League league)
        {
            return new LeagueModel
            {
                DbId = league.DbId,
                ShortName = league.ShortName,
                Name = league.Name,
                FlagURL = league.FlagURL,
                Region = RegionFactory.GetModel(league.Region)
              
            };
        }

        public static LeagueModel GetModel(int apiId, string shortName, string fullName,
            string flagURL, Region region)
        {
            return new LeagueModel
            {
                DbId = apiId,
                ShortName = shortName,
                Name = fullName,
                Region = RegionFactory.GetModel(region),
                FlagURL = flagURL,
              
            };
        }
    }
}