using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Data.Repositories
{
    public class SeasonRepository : BaseApiRepository<Season>
    {
        public SeasonRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}