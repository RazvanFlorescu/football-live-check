using FootballLiveCheck.Domain;

namespace FootballLiveCheck.DbSynchronizer.JSONObjects.JTeams
{
    public class JArena : BaseJsonObject
    {

        public int Capacity { get; set; }

        public string  Name { get; set; }
            
       
    }
}