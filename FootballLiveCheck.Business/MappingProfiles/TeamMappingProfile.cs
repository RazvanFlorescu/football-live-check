using AutoMapper;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Business.Team.Models;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class TeamMappingProfile : Profile
    {
        public TeamMappingProfile()
        {
            CreateMap<Domain.Entities.Team, TeamModel>()
                .ReverseMap()
                .ForMember(e => e.Matches, opt => opt.Ignore());
            CreateMap<JTeam, Domain.Entities.Team>()
                .ForMember(x => x.DbId, opt => opt.MapFrom(src => src.DbId))
                .ForMember(e => e.Matches, opt => opt.Ignore())
                .ForMember(e => e.Arena, opt => opt.MapFrom(src => src.defaultHomeVenue))
                .ForMember(m => m.ArenaId, o => o.MapFrom(p => p.defaultHomeVenue.DbId));

        }
    }
}