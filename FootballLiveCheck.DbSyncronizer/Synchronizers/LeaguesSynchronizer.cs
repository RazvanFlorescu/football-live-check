////using System.Linq;
////using EnsureThat;
////using FootballLiveCheck.DbSynchronizer.JSONMappings;
////using FootballLiveCheck.DbSynchronizer.JSONObjects;
////using FootballLiveCheck.DbSynchronizer.Shared;
////using FootballLiveCheck.Domain.Repositories;

////namespace FootballLiveCheck.DbSynchronizer.Synchronizers
////{
////    public class LeaguesSynchronizer : BaseSynchronizer
////    {
////        private const string endPoint = "/competitions";

////        private readonly ILeagueRepository repository;

////        public LeaguesSynchronizer(ILeagueRepository repository)
////        {
////            EnsureArg.IsNotNull(repository);
////            this.repository = repository;
////            SetLeaguesUrl();
////        }


////        private string LeaguesURL { get; set; }

////        public void Synchronize()
////        {
////            var json = URLToJSONConverter.GetJSONString(LeaguesURL);
////            var unupdatedLeagues = repository.GetAll();
////            var updatedLeagues = JSONDeserializer.DeserializeAsList<JLeague>(json);


////            var entitiesToInsert = updatedLeagues.Where(e => !unupdatedLeagues.Any(de => de.ApiId == e.Id));
////            foreach (var jEntity in entitiesToInsert)
////            {
////                var entity = JLeaguesMappping.CreateEntity(jEntity);
////                repository.Add(entity);
////            } //insert new Entities from Api


////            var entitiesToDelete = unupdatedLeagues.Where(de => updatedLeagues.All(e => de.ApiId != e.Id));
////            foreach (var entity in entitiesToDelete)
////                repository.Delete(entity);
////            //delete entities that don't apear in Api

////            var entitiesToUpdate =
////                updatedLeagues.Where(ae => unupdatedLeagues.Any(de => de.ApiId == ae.Id && !de.Equals(ae)));
////            foreach (var entity in entitiesToUpdate)
////            {
////                var league = repository.GetByApiId(entity.Id);
////                repository.Update(league);
////            } //update entities that changed their status 

////            repository.SaveChanges();
////        }

////        private void SetLeaguesUrl()
////        {
////            LeaguesURL = BaseURL + endPoint + "?api_key=" + APIKey;
////        }
////    }
////}