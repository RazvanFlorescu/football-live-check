using System;
using FootballLiveCheck.Business.Shared;

namespace FootballLiveCheck.Business.Team.Models
{
    public class TeamModel : BaseModel
    {
       
        public string FullName { get; set; }

        public string ShortName { get; set; }

        public int ApiId { get; set; }

        public string ShirtUrl { get; set; }

        //public int ArenaId { get; set; }

        //public int ArenaCapacity { get; set; }

        //public string ArenaName { get; set; }

    }
}