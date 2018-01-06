using System;
using FootballLiveCheck.Business.Shared;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.Team.Models
{
    public class TeamModel : BaseModel
    {
       
        public string FullName { get; set; }

        public string ShortName { get; set; }

        public int ApiId { get; set; }

        public string ShirtUrl { get; set; }

        public ArenaModel Arena { get; set; }



    }
}