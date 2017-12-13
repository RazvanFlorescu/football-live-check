using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Tests.Shared.Factories
{
    public static class LeagueFactory
    {
        public static League GetEntity(int apiId, string shortName, string fullName, string regionName, string flagURL,
            string regionFlagURL)
        {
            return League.Create(apiId, shortName, fullName, regionName, flagURL, regionFlagURL);
        }

        public static LeagueModel GetModel(League league)
        {
            return new LeagueModel
            {
                ApiId = league.ApiId,
                ShortName = league.ShortName,
                FullName = league.FullName,
                RegionName = league.RegionName,
                FlagURL = league.FlagURL,
                RegionFlagURL = league.RegionFlagURL
            };
        }

        public static LeagueModel GetModel(int apiId, string shortName, string fullName, string regionName,
            string flagURL, string regionFlagURL)
        {
            return new LeagueModel
            {
                ApiId = apiId,
                ShortName = shortName,
                FullName = fullName,
                RegionName = regionName,
                FlagURL = flagURL,
                RegionFlagURL = regionFlagURL
            };
        }
    }
}