using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class OutcomeMapping
    {
        public OutcomeMapping(ModelBuilder builder)
        {
            var modelBuilder = builder.Entity<Outcome>();
        }
    }
}