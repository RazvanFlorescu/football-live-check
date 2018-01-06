using FootballLiveCheck.DbSynchronizer.JSONObjects.JLeagues;

namespace FootballLiveCheck.DbSynchronizer.JSONObjects
{
    public class JLeague
    {
        public string FullName { get; set; }

        public int Dbid { get; set; }

        public string FlagUrl { get; set; }

        public string ShortName { get; set; }

        public Region Region { get; set; }
    }
}