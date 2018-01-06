using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Interfaces
{
    public interface IEntitySynchronizer<TEntity, TJson>
        where TEntity : ApiEntity
        where TJson : BaseJsonObject
    {
        void Synchronize(string endPoint);
    }
}