using AutoMapper;
using FootballLiveCheck.Business.Models.JSONObjects.JMatches;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class MatchProfile : Profile
    {
        public MatchProfile()
        {
            CreateMap<JMatch,Domain.Entities.Match>().IncludeBase<BaseJsonObject, DomainEntity>();
        }
    }
}