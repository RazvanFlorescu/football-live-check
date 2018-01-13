namespace FootballLiveCheck.Domain.Entities
{
    public class Team : ApiEntity
    {
        private Team()
        {
        }

        public string FullName { get; private set; }

        public string ShortName { get; private set; }

        public string ShirtUrl { get; private set; }

        public int ArenaId { get; private set; }

        public virtual Arena Arena { get; private set; }
        
        public static Team Create(string fullName, string shortName,
            int apiId, string shirtUrl, Arena arena)
        {
            return new Team
            {
              
               FullName=fullName,
               ShortName = shortName,
               Id = apiId,
               ShirtUrl = shirtUrl,
               Arena = arena
            };
        }
        
    }
}