using AutoMapper;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JMatches;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.MappingProfiles
{
    public class MatchProfile : Profile
    {
        public MatchProfile()
        {
            CreateMap<JMatch,Match>().IncludeBase<BaseJsonObject, DomainEntity>();
        }
    }
}