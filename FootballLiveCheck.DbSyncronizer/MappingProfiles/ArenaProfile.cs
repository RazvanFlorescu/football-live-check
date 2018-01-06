using AutoMapper;
using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JTeams;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.MappingProfiles
{
    public class ArenaProfile : Profile
    {
        public ArenaProfile()
        {
            CreateMap<JArena, Arena>().IncludeBase<BaseJsonObject, DomainEntity>();
        }
    }
}