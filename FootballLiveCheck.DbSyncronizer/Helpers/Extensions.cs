using FootballLiveCheck.Business.Models.JSONObjects.JLeagues;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.Helpers
{
    public static class Extensions
    {
        public static bool Equals(this League league, JLeague jLeague)
        {
            if (league.DbId != jLeague.DbId || league.FullName != jLeague.FullName
                || league.ShortName != jLeague.ShortName || league.FlagURL != jLeague.FlagUrl
                || league.Region.Name != jLeague.Region.Name || league.Region.FlagUrl != league.Region.FlagUrl)
                return false;
            return true;
        }

    }
}