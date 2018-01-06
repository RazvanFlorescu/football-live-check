using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.DbSynchronizer.Helpers
{
    public class TeamHelper : BaseHelper<Team>
    {
        public TeamHelper(ITeamRepository teamRepository)
        {
            repo = teamRepository;
        }
    }
}