using AutoMapper;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JMatches;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.MappingProfiles
{
    public class OutcomeProfile : Profile
    {
        public OutcomeProfile()
        {
            CreateMap<JOutcome,Outcome>().IncludeBase<BaseJsonObject, DomainEntity>();
        }
    }
}