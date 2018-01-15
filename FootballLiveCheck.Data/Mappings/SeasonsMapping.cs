using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class SeasonsMapping
    {
        public SeasonsMapping(ModelBuilder builder)
        {
            var modelBuilder = builder.Entity<Season>();
            modelBuilder.HasMany(s => s.Matches).WithOne(m => m.Season).OnDelete(DeleteBehavior.Restrict);
        }
    }
}