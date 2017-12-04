using AutoMapper;
using FootballLiveCheck.Business.Team.Models;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class TeamMappingProfile : Profile
    {
        public TeamMappingProfile()
        {
            CreateMap<Domain.Entities.Team, TeamModel>().ReverseMap();
        }
    }
}