using System;

namespace FootballLiveCheck.Domain.Entities
{
    public class Match : ApiEntity
    {
        private Match()
        {
        }

        public int HomeTeamId { get; private set; }

        public virtual Team HomeTeam { get; private set; }

        public int AwayTeamId { get; private set; }

        public virtual Team AwayTeam { get; private set; }
        public int AwayGoals { get; private set; }
        public string Start { get; private set; }
        
        public int SeasonId { get; private set; }

        public virtual Season Season { get; private set; }

        public int LeagueId { get; private set; }

        public virtual League League { get; private set; }

        public int HomeGoals { get; private set; }

        public Guid OutcomeId { get; private set; }

        public virtual Outcome Outcome { get; private set; }

        public int CurrentStateId { get; private set; }
    }
}