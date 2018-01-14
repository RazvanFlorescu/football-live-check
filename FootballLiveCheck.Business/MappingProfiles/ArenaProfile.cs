using AutoMapper;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class ArenaProfile : Profile
    {
        public ArenaProfile()
        {
            CreateMap<JArena, Arena>().IncludeBase<BaseJsonObject, DomainEntity>();
        }
    }
}