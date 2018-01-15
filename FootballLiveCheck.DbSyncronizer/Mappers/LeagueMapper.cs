using EnsureThat;
using FootballLiveCheck.Business.Models.JSONObjects.JLeagues;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Mappers
{
    public class LeagueMapper : IJsonMapper<League, JLeague>
    {
        private readonly IJsonMapper<Region, JRegion> regionMapper;

        public LeagueMapper(IJsonMapper<Region, JRegion> regionMapper)
        {
            EnsureArg.IsNotNull(regionMapper);
            this.regionMapper = regionMapper;
        }

        public League Map(JLeague model)
        {
            var region = regionMapper.Map(model.Region);
            var regionId = region != null ? region.DbId : (int?) null;
            var league = League.Create(model.DbId, model.ShortName, model.Name, model.FlagUrl, region);
            league.SetRegionId(regionId);
            return league;
        }
    }
}