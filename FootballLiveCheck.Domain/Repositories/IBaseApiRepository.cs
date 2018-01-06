using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Repositories
{
    public interface IBaseApiRepository<T> : ICommonRepository<T>
        where T : ApiEntity
    {
        T GetById(int id);
    }
}