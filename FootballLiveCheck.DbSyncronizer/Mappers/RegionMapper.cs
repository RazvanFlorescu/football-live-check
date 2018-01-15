using FootballLiveCheck.Business.Models.JSONObjects.JLeagues;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Mappers
{
    public class RegionMapper : IJsonMapper<Region, JRegion>
    {
        public Region Map(JRegion model)
        {
            return model != null ? Region.Create(model.DbId, model.Name, model.FlagUrl) : null;
        }
    }
}