using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class SubscriberRepository: BaseRepository<Subscriber>, ISubscriberRepository
    {
        public SubscriberRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
