using AutoMapper;
using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JTeams;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.MappingProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<JTeam, Team>().IncludeBase<BaseJsonObject, DomainEntity>();
        }
    }
}