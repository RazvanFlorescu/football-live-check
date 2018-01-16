using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class MatchMapping
    {
        public MatchMapping(ModelBuilder builder)
        {
            var modelBuilder = builder.Entity<Match>();
            //modelBuilder.HasOne(m => m.Outcome).WithOne().HasForeignKey<Match>(m => m.OutcomeId);
            modelBuilder.HasOne(m => m.League).WithMany().HasForeignKey(m => m.LeagueId).OnDelete(DeleteBehavior.Restrict); ;
            modelBuilder.HasOne(m => m.Season).WithMany().HasForeignKey(m => m.SeasonId).OnDelete(DeleteBehavior.Restrict);
            // modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.HasOne(m => m.HomeTeam);
            modelBuilder.HasOne(m => m.AwayTeam);
            
        }
    }
}