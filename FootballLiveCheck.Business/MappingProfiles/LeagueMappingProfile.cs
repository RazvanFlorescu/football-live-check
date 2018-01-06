using AutoMapper;
using FootballLiveCheck.Business.League.Models;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class LeagueMappingProfile : Profile
    {
        public LeagueMappingProfile()
        {
            CreateMap<Domain.Entities.League, LeagueModel>().ReverseMap();
        }
    }
}