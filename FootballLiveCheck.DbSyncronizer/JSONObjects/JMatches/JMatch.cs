using FootballLiveCheck.DbSynchronizer.JSONObjects.JSeasons;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JTeams;
using FootballLiveCheck.Domain;

namespace FootballLiveCheck.DbSynchronizer.JSONObjects.JMatches
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
    }
}