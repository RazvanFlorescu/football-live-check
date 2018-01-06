using System;
using FootballLiveCheck.DbSynchronizer.JSONObjects.JLeagues;
using FootballLiveCheck.Domain;

namespace FootballLiveCheck.DbSynchronizer.JSONObjects
{
    public class JLeague : BaseJsonObject
    {
        public Guid Id { get; set; }

        public Guid RegionId { get; set; }

        public int ApiId { get; set; }

        public string FullName { get; set; }

        public string FlagUrl { get; set; }

        public string ShortName { get; set; }

        public JRegion Region { get; set; }
    }
}