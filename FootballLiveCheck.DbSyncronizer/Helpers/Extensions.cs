using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Helpers
{
    public static class Extensions
    {
        public static bool Equals(this League league, JLeague jLeague)
        {
            if (league.ApiId != jLeague.Dbid || league.FullName != jLeague.FullName
                || league.ShortName != jLeague.ShortName || league.FlagURL != jLeague.FlagUrl
                || league.RegionName != jLeague.Region.Name || league.RegionFlagURL != league.RegionFlagURL)
                return false;
            return true;
        }
    }
}