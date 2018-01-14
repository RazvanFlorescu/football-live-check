using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Mappers
{
    public class ArenaMapper : IJsonMapper<Arena, JArena>
    {
        public Arena Map(JArena model)
        {
            return model != null ? Arena.Create(model.DbId, model.Name, model.Capacity) : null;
        }
    }
}