using AutoMapper;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.Models.JSONObjects.JLeagues;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class LeagueMappingProfile : Profile
    {
        public LeagueMappingProfile()
        {
            CreateMap<Domain.Entities.League, LeagueModel>().ReverseMap();
            CreateMap<JLeague, Domain.Entities.League>()
                .ConvertUsing(Convert);
            ////.ReverseMap()
            ////.ForMember(j => j.DbId, opt => opt.MapFrom(e => e.Id));
        }

        private Domain.Entities.League Convert(JLeague model)
        {
            return Domain.Entities.League.Create(model.DbId, model.ShortName, model.FullName, model.FlagUrl, model.Region.DbId);
        }
    }
}