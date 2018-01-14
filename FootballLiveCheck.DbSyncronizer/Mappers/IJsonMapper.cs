using FootballLiveCheck.Domain;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Mappers
{
    public interface IJsonMapper<TEntity, TJsonObject>
        where TEntity : ApiEntity
        where TJsonObject : BaseJsonObject
    {
        TEntity Map(TJsonObject model);
    }
}