using System;
using System.Linq;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class BaseRepository<T> : CommonRepository<T>, IBaseRepository<T> where T : DomainEntity
    {
        public BaseRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public T GetById(Guid id)
        {
            return entitiesSet.FirstOrDefault(e => e.Id == id);
        }
    }
}