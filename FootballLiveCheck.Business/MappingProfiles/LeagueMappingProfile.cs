using AutoMapper;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Domain.Entities;

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