using System;
using System.Linq;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        IQueryable<T> Search(Func<T, bool> filterFunc);

        IQueryable<T> GetAllAsNoTracking();

        T GetById(Guid id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void SaveChanges();

        T GetByApiId(int id);
    }
}