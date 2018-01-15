using AutoMapper;
using FootballLiveCheck.Business.Match.Models;
using FootballLiveCheck.Business.Models.JSONObjects.JMatches;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class MatchProfile : Profile
    {
        public MatchProfile()
        {
            CreateMap<Domain.Entities.Match, MatchModel>().ReverseMap();
            CreateMap<JMatch, Domain.Entities.Match>().IncludeBase<BaseJsonObject, DomainEntity>()

                .ForMember(e => e.HomeTeamId, opt => opt.MapFrom(src => src.HomeTeam.DbId))
                .ForMember(e => e.AwayTeamId, opt => opt.MapFrom(src => src.AwayTeam.DbId))
                .ForMember(e => e.SeasonId, opt => opt.MapFrom(src => src.Season.DbId))
                .ForMember(e => e.LeagueId, opt => opt.MapFrom(src => src.Competition.DbId))
                .ForMember(e => e.ArenaId, opt => opt.MapFrom(src => src.Venue.DbId))
                .ForMember(e => e.League, opt => opt.Ignore())
                .ForMember(e => e.Season, opt => opt.Ignore())
                .ForMember(e => e.HomeTeam, opt => opt.Ignore())
                .ForMember(e => e.AwayTeam, opt => opt.Ignore())
                .ForMember(e => e.Arena, opt => opt.Ignore());

        }
    }
}