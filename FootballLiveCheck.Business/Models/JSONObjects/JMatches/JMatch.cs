using FootballLiveCheck.Business.Models.JSONObjects.JLeagues;
using FootballLiveCheck.Business.Models.JSONObjects.JSeasons;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Domain;

namespace FootballLiveCheck.Business.Models.JSONObjects.JMatches
{
    public class JMatch : BaseJsonObject
    {
        public JTeam HomeTeam { get; set; }
        public JTeam AwayTeam { get; set; }
        public int AwayGoals { get; set; }
        public string Start { get; set; }
        public JSeason Season { get; set; }
        public JLeague Competition { get; set; }

        public int HomeGoals { get; set; }

        public JOutcome Outcome { get; set; }

        public int CurrentState { get; set; }

        public JArena Venue { get; set; }
    }
}