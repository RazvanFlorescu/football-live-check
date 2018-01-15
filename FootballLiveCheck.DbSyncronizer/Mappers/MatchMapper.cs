using EnsureThat;
using FootballLiveCheck.Business.Models.JSONObjects.JMatches;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Mappers
{
    public class MatchMapper : IJsonMapper<Match, JMatch>
    {
       // private readonly IJsonMapper<Outcome,JOutcome> outcomeMapper;

        public Match Map(JMatch model)
        {
            int? arenaId = model.Venue != null ? model.Venue.DbId : (int?)null;
            var match = Match.Create(model.DbId, model.HomeTeam.DbId,model.AwayTeam.DbId,
                model.AwayGoals,model.Start,model.Season.DbId,model.Competition.DbId,
                model.HomeGoals,model.CurrentState);
            match.SetArenaId(arenaId);
            return match;
        }
    }
}