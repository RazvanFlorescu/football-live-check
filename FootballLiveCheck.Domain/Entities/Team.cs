using System;

namespace FootballLiveCheck.Domain.Entities
{
    public class Team : BaseEntity
    {
        private Team()
        {
        }

        public string FullName { get; private set; }

        public string ShortName { get; private set; }

        public int ApiId { get; private set; }

        public string ShirtUrl { get; private set; }

        //public int ArenaId { get; private set; }

        //public int ArenaCapacity { get; private set; }

        //public string ArenaName { get; private set; }
        
        public static Team Create(string fullName, string shortName,
            int apiId, string shirtUrl)
        {
            return new Team
            {
              
               FullName=fullName,
               ShortName = shortName,
               ApiId = apiId,
               ShirtUrl = shirtUrl,
               //ArenaCapacity = arenaCapacity,
               //ArenaId = arenaId,
               //ArenaName = arenaName
            };
        }
        
    }
}