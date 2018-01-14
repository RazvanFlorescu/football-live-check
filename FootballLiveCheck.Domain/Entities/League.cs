using System;

namespace FootballLiveCheck.Domain.Entities
{
    public class League : ApiEntity
    {
        private League()
        {
        }
        
        public string ShortName { get; private set; }

        public string FullName { get; private set; }

        public string FlagURL { get; private set; }

        public int RegionId { get; private set; }

        public virtual Region Region { get; private set; }

        public static League Create(int apiId, string shortName, string fullName, string flagURL, Region region)
        {
            return new League
            {
                DbId = apiId,
                ShortName = shortName,
                FullName = fullName,
                FlagURL = flagURL,
                Region = region
            };
        }

        public static League Create(int apiId, string shortName, string fullName, string flagURL, int regionId)
        {
            return new League
            {
                DbId = apiId,
                ShortName = shortName,
                FullName = fullName,
                FlagURL = flagURL,
                RegionId = regionId
            };
        }


    }
}