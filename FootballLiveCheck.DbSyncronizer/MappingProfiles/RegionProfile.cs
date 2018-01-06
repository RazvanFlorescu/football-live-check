using AutoMapper;
using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JLeagues;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.MappingProfiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<JRegion,Region>().ConvertUsing(Convert);
        }

        private Region Convert(JRegion model)
        {
            return Region.Create(model.Name, model.FlagUrl);
        }
    }
}