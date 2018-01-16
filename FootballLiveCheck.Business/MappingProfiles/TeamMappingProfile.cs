using AutoMapper;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class TeamMappingProfile : Profile
    {
        public TeamMappingProfile()
        {
            CreateMap<Domain.Entities.Team, TeamModel>()
                .ReverseMap()
                .ForMember(e => e.Matches, opt => opt.Ignore());
            CreateMap<JTeam, Domain.Entities.Team>().IncludeBase<BaseJsonObject, ApiEntity>()
                .ForMember(x => x.DbId, opt => opt.MapFrom(src => src.DbId))
                .ForMember(e => e.Matches, opt => opt.Ignore())
                .ForMember(e => e.Arena, opt => opt.MapFrom(src => src.defaultHomeVenue))
                .ForMember(m => m.ArenaId, o => o.MapFrom(p => p.defaultHomeVenue.DbId));
            CreateMap<Domain.Entities.Team,JTeam>().IncludeBase< ApiEntity,BaseJsonObject>()
                .ForMember(e => e.Matches, opt => opt.Ignore())
                .ForMember(e => e.defaultHomeVenue, opt => opt.MapFrom(src => src.Arena))
                .ForMember(m => m.defaultHomeVenue.DbId, o => o.MapFrom(p => p.ArenaId));
        }
    }
}