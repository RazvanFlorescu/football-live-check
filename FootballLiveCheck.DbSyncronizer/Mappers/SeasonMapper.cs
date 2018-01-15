using EnsureThat;
using FootballLiveCheck.Business.Models.JSONObjects.JSeasons;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Mappers
{
    public class SeasonMapper : IJsonMapper<Season,JSeason>
    {
        public Season Map(JSeason model)
        {
            return Season.Create(model.DbId, model.Name);
        }
    }
}