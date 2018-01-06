using AutoMapper;
using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.MappingProfiles
{
    public class LeagueProfile : Profile
    {
        public LeagueProfile()
        {
            CreateMap<JLeague, League>()
                .ConvertUsing(Convert);
            ////.ReverseMap()
            ////.ForMember(j => j.DbId, opt => opt.MapFrom(e => e.Id));
        }

        private League Convert(JLeague model)
        {
            return League.Create(model.DbId, model.ShortName, model.FullName, model.FlagUrl, model.Region.DbId);
        }
    }
}