using System.ComponentModel.DataAnnotations.Schema;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.Match.Models
{
    public class MatchModel
    {
       

        public TeamModel HomeTeam { get; set; }

        public TeamModel AwayTeam { get; set; }

        public int AwayGoals { get;  set; }

        public string Start { get;  set; }

        public SeasonModel Season { get;  set; }

        public LeagueModel League { get; set; }

        public int HomeGoals { get; set; }

        //public virtual OutcomeModel Outcome { get; private set; }

        public int CurrentState{ get; set; }
    }
}