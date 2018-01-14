using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FootballLiveCheck.Data.Mappings
{
    public  class TeamMapping
    {
        public TeamMapping(ModelBuilder builder)
        {
            var entityBuilder = builder.Entity<Team>();
            entityBuilder.HasMany(t => t.Matches).WithOne().OnDelete(DeleteBehavior.Restrict);
            // entityBuilder.HasOne(t => t.Arena).WithOne().HasForeignKey<Team>(t => t.ArenaId);
            // entityBuilder.HasAlternateKey(a => a.DbId);
        }
    }
}