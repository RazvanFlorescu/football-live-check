using System;
using System.Linq;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Repositories
{
    public interface IBaseRepository<T> : ICommonRepository<T> where T : DomainEntity
    {
        T GetById(Guid id);
    }
}