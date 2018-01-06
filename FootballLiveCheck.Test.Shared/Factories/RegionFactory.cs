using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Tests.Shared.Factories
{
    public class RegionFactory
    {
        public static RegionModel GetModel(Region region)
        {
            return new RegionModel()
            {
                FlagURL = region.FlagUrl,
                Name = region.Name
            };
        }
    }
}