using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FootballLiveCheck.Data.Mappings
{
    public  class TeamMapping
    {
        public TeamMapping(ModelBuilder builder)
        {
            builder.Entity<Team>()
                .HasKey(t => t.Id);
        }
    }
}