using System;
using System.Collections.Generic;
using System.Linq;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Data.Repositories
{
    public class LeagueRepository : BaseApiRepository<League>, ILeagueRepository
    {
        private readonly int[] importantLeaguesDbIds =
            {2,11,36,37,44,46,47,49,77,93,48,146,152,160,374};

        public LeagueRepository(DatabaseContext dbContext) : base(dbContext)
        {
          
        }
        public IReadOnlyCollection<League> GetTopLeagues()
        {
            return entitiesSet.Where(l=> Array.IndexOf(importantLeaguesDbIds,l.DbId) != -1 ).ToList();
        }
    }
}