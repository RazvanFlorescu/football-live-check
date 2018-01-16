using FootballLiveCheck.Business.Shared;

namespace FootballLiveCheck.Business.League.Models
{
    public class LeagueModel : BaseModel
    {
       // public int DbId { get; set; }

        public string ShortName { get; set; }

        public string Name { get; set; }

        public string FlagURL { get; set; }

        public int?  RegionId { get; set; }

        public RegionModel Region { get; set; }
    }
}