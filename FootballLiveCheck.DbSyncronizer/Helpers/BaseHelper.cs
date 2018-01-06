using System.Linq;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.DbSynchronizer.Helpers
{
    public class BaseHelper<T> where T : BaseEntity
    {
        protected IBaseRepository<T> repo;

        public IQueryable<T> GetAll()
        {
            return repo.GetAll();
        }

        public void Insert(T entity)
        {
            repo.Add(entity);
        }

        public void Delete(T entity)
        {
            repo.Delete(entity);
        }

        public void Update(T entity)
        {
            repo.Update(entity);
        }

        public T GetByApiId(int ApiId)
        {
            var entity = repo.GetByApiId(ApiId);
            return entity;
        }
    }
}