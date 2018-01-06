using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class UserMapping
    {
        public UserMapping(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasKey(c => c.Id);
        }
    }
}