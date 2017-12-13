using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class LeagueMapping
    {
        public LeagueMapping(ModelBuilder builder)
        {
            builder.Entity<League>()
                .HasKey(c => c.Id);
        }
    }
}