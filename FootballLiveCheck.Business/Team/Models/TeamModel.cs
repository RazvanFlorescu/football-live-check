using System;
using FootballLiveCheck.Business.Shared;

namespace FootballLiveCheck.Business.Team.Models
{
    public class TeamModel : BaseModel
    {
        public string Name { get; set; }

        public Guid LeagueId { get; set; }

        public int Points { get; set; }
    }
}