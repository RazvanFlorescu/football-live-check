using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class MatchMapping
    {
        public MatchMapping(ModelBuilder builder)
        {
            var modelBuilder = builder.Entity<Match>();
            modelBuilder.HasOne(m => m.Outcome).WithOne().HasForeignKey<Match>(m => m.OutcomeId);
            modelBuilder.HasOne(m => m.League).WithMany().HasForeignKey(m => m.LeagueId).OnDelete(DeleteBehavior.SetNull); ;
            modelBuilder.HasOne(m => m.Season).WithMany().HasForeignKey(m => m.SeasonId).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.HasOne(m => m.HomeTeam).WithMany().HasForeignKey(m => m.HomeTeamId).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.HasOne(m => m.AwayTeam).WithMany().HasForeignKey(m => m.AwayTeamId).OnDelete(DeleteBehavior.SetNull);

            modelBuilder.HasAlternateKey(a => a.Id);
        }
    }
}