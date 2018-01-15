using AutoMapper;
using FootballLiveCheck.Business.Models.JSONObjects.JMatches;
using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class OutcomeProfile : Profile
    {
        public OutcomeProfile()
        {
            CreateMap<JOutcome,Outcome>().ConvertUsing(Convert);
        }
        private Outcome Convert(JOutcome model)
        {
            return Outcome.Create(model.Winner, model.Type, model.AfterExtraTime);
        }
    }
}