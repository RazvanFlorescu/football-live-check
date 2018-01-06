namespace FootballLiveCheck.Domain.Entities
{
    public class League : BaseEntity
    {
        private League()
        {
        }

        public int ApiId { get; private set; }
        public string ShortName { get; private set; }
        public string FullName { get; private set; }
        public string RegionName { get; private set; }
        public string FlagURL { get; private set; }
        public string RegionFlagURL { get; private set; }

        public static League Create(int apiId, string shortName, string fullName, string regionName, string flagURL, string regionFlagURL)
        {
            return new League
            {
                ApiId = apiId,
                ShortName = shortName,
                FullName = fullName,
                RegionName = regionName,
                FlagURL = flagURL,
                RegionFlagURL = regionFlagURL
            };
        }

      
    }
}