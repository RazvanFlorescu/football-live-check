using AutoMapper;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JSeasons;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.MappingProfiles
{
    public class SeasonProfile : Profile
    {
        public SeasonProfile()
        {
            CreateMap<JSeason,Season>().IncludeBase<BaseJsonObject, DomainEntity>();
        }
    }
}