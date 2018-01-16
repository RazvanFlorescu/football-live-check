using System;
using System.Linq;
using FootballLiveCheck.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Repositories
{
    public abstract class CommonRepository<T> : ICommonRepository<T>
        where T : class
    {
        protected readonly DatabaseContext dbContext;
        protected readonly DbSet<T> entitiesSet;

        public CommonRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
            entitiesSet = dbContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return entitiesSet.AsQueryable();
        }

        public IQueryable<T> Search(Func<T, bool> filterFunc)
        {
            return entitiesSet.Where(e => filterFunc(e)).AsQueryable();
        }

        public IQueryable<T> GetAllAsNoTracking()
        {
            return entitiesSet.AsNoTracking();
        }

        public void Add(T entity)
        {
           
             entitiesSet.Add(entity);
           
        }

        public void Update(T entity)
        {
            entitiesSet.Update(entity);
        }

        public void Delete(T entity)
        {
            entitiesSet.Remove(entity);
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
    }
}