using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class LeagueMapping
    {
        public LeagueMapping(ModelBuilder builder)
        {
            var entityBuilder = builder.Entity<League>();
            entityBuilder.HasOne(l => l.Region).WithMany().HasForeignKey(l => l.RegionId);
        }
    }
}