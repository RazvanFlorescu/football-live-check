using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballLiveCheck.Domain.Entities
{
    public class Match : ApiEntity
    {
        private Match()
        {
        }

        public int HomeTeamId { get; private set; }

        [NotMapped]
        public virtual Team HomeTeam { get; private set; }

        public int AwayTeamId { get; private set; }

        [NotMapped]
        public virtual Team AwayTeam { get; private set; }

        public int AwayGoals { get; private set; }

        public DateTime StartDate { get; private set; }

        public string Start { get; private set; }

        public int SeasonId { get; private set; }

        [NotMapped]
        public virtual Season Season { get; private set; }

        public int LeagueId { get; private set; }

        [NotMapped]
        public virtual League League { get; private set; }

        public int HomeGoals { get; private set; }
        //public Guid OutcomeId { get; private set; }

        // public virtual Outcome Outcome { get; private set; }

        public int CurrentState { get; private set; }

        [NotMapped]
        public virtual Arena Arena { get; private set; }

        public int? ArenaId { get; private set; }

        public static Match Create(int dbId, int homeTeamId,
            int awayTeamId, int awayGoals, string start, int seasonId, int leagueId,
            int homeGoals, int currentState)
        {
            return new Match
            {
                DbId = dbId,
                HomeTeamId = homeTeamId,
                AwayTeamId = awayTeamId,
                AwayGoals = awayGoals,
                Start = start,
                StartDate = DomainHelper.UnixTimeStampToDateTime(start),
                SeasonId = seasonId,
                LeagueId = leagueId,
                HomeGoals = homeGoals,
                //Outcome = outcome,
                //OutcomeId = outcome.Id,
                CurrentState = currentState
            };
        }

        public void SetArenaId(int? arenaId)
        {
            ArenaId = arenaId;
        }


        public bool AreEquals(Match m)
        {
            return true;
            //return (this.DbId == m.DbId &&
            //        this.AwayTeamId == m.AwayTeamId &&
            //        this.HomeTeamId == m.HomeTeamId &&
            //        this.CurrentState == m.CurrentState &&
            //        this.LeagueId == m.LeagueId &&
            //        this.ArenaId == m.ArenaId &&
            //        this.Start == m.Start &&
            //        this.HomeGoals == m.HomeGoals &&
            //        this.AwayGoals == m.AwayGoals);
        }
    }
}