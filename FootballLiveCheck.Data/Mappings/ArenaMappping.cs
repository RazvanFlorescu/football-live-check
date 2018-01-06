using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class ArenaMappping
    {
        public ArenaMappping(ModelBuilder builder)
        {
            builder.Entity<Arena>();
        }
    }
}