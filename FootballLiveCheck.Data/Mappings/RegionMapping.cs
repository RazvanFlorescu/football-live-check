using FootballLiveCheck.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Mappings
{
    public class RegionMapping
    {
        public RegionMapping(ModelBuilder builder)
        {
            builder.Entity<Region>();
        }
    }
}