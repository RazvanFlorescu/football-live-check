using System.Collections.Generic;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Domain.Repositories
{
    public interface ILeagueRepository : IBaseApiRepository<League>
    {
        IReadOnlyCollection<League> GetTopLeagues();
    }
}