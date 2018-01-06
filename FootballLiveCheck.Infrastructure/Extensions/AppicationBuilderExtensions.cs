using FootballLiveCheck.CqrsCore.DependencyInjection;
using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JMatches;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JSeasons;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JTeams;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Interfaces;
using Microsoft.AspNetCore.Builder;

namespace FootballLiveCheck.Infrastructure.Extensions
{
    public static class AppicationBuilderExtensions
    {

        public static void SynchronizeDb(this IApplicationBuilder services, IDependencyScope scope)
        {
            var leagueSynchronizer = scope.Resolve<IEntitySynchronizer<League, JLeague>>();
            leagueSynchronizer.Synchronize("/competitions");

            ////var teamsSynchronizer = scope.Resolve<IEntitySynchronizer<Team, JTeam>>();
            ////teamsSynchronizer.Synchronize(("/teams"));

            ////var matchesSynchronizer = scope.Resolve<IEntitySynchronizer<Match, JMatch>>();
            ////matchesSynchronizer.Synchronize("/matches");

            ////var seasonsSynchronizer = scope.Resolve<IEntitySynchronizer<Season, JSeason>>();
            ////seasonsSynchronizer.Synchronize("/seasons");

        }
    }
}