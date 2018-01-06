////using System.Linq;
////using FootballLiveCheck.Domain.Entities;
////using FootballLiveCheck.Domain.Repositories;

////namespace FootballLiveCheck.DbSynchronizer.Helpers
////{
////    public class BaseHelper<T> where T : DomainEntity
////    {
////        protected IBaseRepository<T> repo;

////        public IQueryable<T> GetAll()
////        {
////            return repo.GetAll();
////        }

////        public void Insert(T entity)
////        {
////            repo.Add(entity);
////        }

////        public void Delete(T entity)
////        {
////            repo.Delete(entity);
////        }

////        public void Update(T entity)
////        {
////            repo.Update(entity);
////        }

       
////    }
////}