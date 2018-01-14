using AutoMapper;
using FootballLiveCheck.Business.Models.JSONObjects.JSeasons;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class SeasonProfile : Profile
    {
        public SeasonProfile()
        {
            CreateMap<JSeason,Season>().IncludeBase<BaseJsonObject, DomainEntity>();
        }
    }
}