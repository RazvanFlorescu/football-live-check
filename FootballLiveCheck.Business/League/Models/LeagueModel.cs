using FootballLiveCheck.Business.Shared;

namespace FootballLiveCheck.Business.League.Models
{
    public class LeagueModel : BaseModel
    {
        public int ApiId { get; set; }

        public string ShortName { get; set; }

        public string FullName { get; set; }


        public string FlagURL { get; set; }

        public RegionModel Region { get; set; }
    }
}