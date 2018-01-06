using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.DbSynchronizer.JSONMappings
{
    public class JLeaguesMappping
    {
        public static League CreateEntity(JLeague jLeague)
        {
            EnsureArg.IsNotNull(jLeague);
            var entity = League.Create(jLeague.Dbid, jLeague.ShortName, jLeague.FullName, jLeague.Region.Name,
                jLeague.FlagUrl, jLeague.Region.FlagUrl);
            return entity;
        }

        public static LeagueModel UpdateModel(LeagueModel league, JLeague jLeague)
        {
            league.FullName = jLeague.FullName;
            league.ShortName = jLeague.ShortName;
            league.FlagURL = jLeague.FlagUrl;
            league.RegionFlagURL = jLeague.Region.FlagUrl;
            league.RegionName = jLeague.Region.Name;

            return league;
        }



    }
}