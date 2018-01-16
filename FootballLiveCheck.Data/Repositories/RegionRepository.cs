using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Data.Repositories
{
    public class RegionRepository : BaseApiRepository<Region>
    {
        public RegionRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}