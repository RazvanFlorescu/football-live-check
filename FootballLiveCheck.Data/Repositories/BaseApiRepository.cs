using System.Linq;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FootballLiveCheck.Data.Repositories
{
    public class BaseApiRepository<T> : CommonRepository<T>, IBaseApiRepository<T>
        where T : ApiEntity
    {
        public BaseApiRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public T GetById(int id)
        {
            return entitiesSet.FirstOrDefault(e => e.Id == id);
        }

        public new void SaveChanges()
        {
            ////dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT ? ON");
            dbContext.SaveChanges();
            ////dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT ? OFF");
        }
    }
}