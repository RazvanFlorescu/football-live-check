using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class SubscriberMapping
    {
        public SubscriberMapping(ModelBuilder builder)
        {
            var entityBuilder = builder.Entity<Subscriber>();
        }
    }
}
