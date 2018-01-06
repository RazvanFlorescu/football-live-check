using FootballLiveCheck.Domain;

namespace FootballLiveCheck.DbSynchronizer.JSONObjects.JTeams
{
    public class JTeam : BaseJsonObject
    {
        public string Name { get; set; }

      
        public bool IsNational { get; set; }

        public string ShirtUrl { get; set; }

        public string ShortName { get; set; }

        public string ShortCode { get; set; }

        public JArena Arena { get; set; }
    }
}