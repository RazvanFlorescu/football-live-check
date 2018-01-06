using System;
using System.Linq;

namespace FootballLiveCheck.Domain.Repositories
{
    public interface ICommonRepository<T>
        where T : class
    {
        IQueryable<T> GetAll();

        IQueryable<T> Search(Func<T, bool> filterFunc);

        IQueryable<T> GetAllAsNoTracking();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void SaveChanges();
    }
}