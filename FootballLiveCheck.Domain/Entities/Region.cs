using System.Reflection.Metadata.Ecma335;

namespace FootballLiveCheck.Domain.Entities
{
    public class Region : ApiEntity
    {
        public string Name { get; private set; }
        public string FlagUrl { get; private set; }

        public static Region Create(int dbid, string name, string flagurl)
        {
            return new Region()
            {
                DbId = dbid,
                Name = name,
                FlagUrl = flagurl
            };
        }
    }
}