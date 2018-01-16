using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Interfaces
{
    public interface IEntityComparer<TEntity>
        where TEntity : ApiEntity
    {
        bool AreEquals(TEntity t1);
    }
}