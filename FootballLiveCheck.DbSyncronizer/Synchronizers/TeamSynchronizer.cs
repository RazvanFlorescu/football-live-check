using System.Collections.Generic;
using System.Linq;
using FootballLiveCheck.DbSynchronizer.Helpers;
using FootballLiveCheck.DbSynchronizer.JSONMappings;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JTeams;
using FootballLiveCheck.DbSynchronizer.Shared;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.DbSynchronizer.Synchronizers
{
    public class TeamSynchronizer : BaseSynchronizer
    {
        private const string endPoint = "/teams";

        private readonly TeamHelper teamHelper;

        public TeamSynchronizer(ITeamRepository teamRepository)
        {
            SetTeamsUrl();
            teamHelper = new TeamHelper(teamRepository);
        }


        private string TeamsURL { get; set; }

        private void SetTeamsUrl()
        {
            TeamsURL = BaseURL + endPoint + "?api_key=" + APIKey;
        }

        public void Synchronize()
        {
            var json = URLToJSONConverter.GetJSONString(TeamsURL);
            var unupdatedTeams = teamHelper.GetAll();
            var updatedTeams = JSONDeserializer.DeserializeAsList<JTeam>(json);


            var entitiesToInsert = updatedTeams.Where(de => !unupdatedTeams.Any(ae => ae.ApiId == de.Dbid));
            foreach (var jEntity in entitiesToInsert)
            {
                var entity = JTeamsMapping.CreateEntity(jEntity);
                teamHelper.Insert(entity);
            } //insert new Entities from Api

            /*
                        var entitiesToDelete = unupdatedTeams.Where(ae => !updatedTeams.Any(de => ae.ApiId == de.Dbid));
                        foreach (var entity in entitiesToDelete)
                            teamHelper.Delete(entity);
                        //delete entities that don't apear in Api

                        var entitiesToUpdate =
                            updatedTeams.Where(ae => unupdatedTeams.Any(de => de.ApiId == ae.Dbid && !de.Equals(ae)));
                        foreach (var entity in entitiesToUpdate)
                        {
                            var team = teamHelper.GetByApiId(entity.Dbid);
                            teamHelper.Update(team);
                        } //update entities that changed their status 

            */
        }

    }
}