using FootballLiveCheck.Business.Models.JSONObjects.JLeagues;
using FootballLiveCheck.Business.Models.JSONObjects.JMatches;
using FootballLiveCheck.Business.Models.JSONObjects.JSeasons;
using FootballLiveCheck.Business.Models.JSONObjects.JTeams;
using FootballLiveCheck.CqrsCore.DependencyInjection;
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


            var teamsSynchronizer = scope.Resolve<IEntitySynchronizer<Team, JTeam>>();
            teamsSynchronizer.Synchronize(("/teams"));

            var seasonsSynchronizer = scope.Resolve<IEntitySynchronizer<Season, JSeason>>();
            seasonsSynchronizer.Synchronize("/seasons");

            var matchesSynchronizer = scope.Resolve<IEntitySynchronizer<Match, JMatch>>();
            matchesSynchronizer.Synchronize("/matches");
        }
    }
}