using System.Linq;

using FootballLiveCheck.DbSynchronizer.Helpers;
using FootballLiveCheck.DbSynchronizer.JSONMappings;
using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.DbSynchronizer.Shared;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.DbSynchronizer.Synchronizers
{
    public class LeaguesSynchronizer : BaseSynchronizer
    {
        private const string endPoint = "/competitions";

        private readonly LeagueHelper leagueHelper;


        private string LeaguesURL { get; set; }

        private void SetLeaguesUrl()
        {
            LeaguesURL = BaseURL + endPoint + "?api_key=" + APIKey;
        }
 
        public LeaguesSynchronizer(ILeagueRepository leagueRepository)
        {
            SetLeaguesUrl();
            leagueHelper = new LeagueHelper(leagueRepository);
        }

        public void Synchronize()
        {
            var json = URLToJSONConverter.GetJSONString(LeaguesURL);
            var unupdatedLeagues = leagueHelper.GetAll();
            var updatedLeagues = JSONDeserializer.DeserializeAsList<JLeague>(json);


            var entitiesToInsert = updatedLeagues.Where(e => !unupdatedLeagues.Any(de => de.ApiId == e.Dbid));
            foreach (var jEntity in entitiesToInsert)
            {
                var entity =  JLeaguesMappping.CreateEntity(jEntity);
                leagueHelper.Insert(entity);  
            }    //insert new Entities from Api


            var entitiesToDelete = unupdatedLeagues.Where(de => !updatedLeagues.Any(e => de.ApiId == e.Dbid));
            foreach (var entity in entitiesToDelete)
                leagueHelper.Delete(entity);
            //delete entities that don't apear in Api

            var entitiesToUpdate =
                updatedLeagues.Where(ae => unupdatedLeagues.Any(de => de.ApiId == ae.Dbid && !de.Equals(ae)));
            foreach (var entity in entitiesToUpdate)
            {
                var league = leagueHelper.GetByApiId(entity.Dbid);
                leagueHelper.Update(league);
            } //update entities that changed their status 
        }
    }
}