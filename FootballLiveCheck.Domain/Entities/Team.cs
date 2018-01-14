using System;
using System.Collections;
using System.Collections.Generic;

namespace FootballLiveCheck.Domain.Entities
{
    public class Team : ApiEntity
    {
        private Team()
        {
        }

        public string Name { get; private set; }

        public string ShortName { get; private set; }

        public string ShirtUrl { get; private set; }

      // public int ArenaId { get; private set; }

        public virtual Arena Arena { get; private set; }

        public ICollection<Match> Matches { get; private set; }

        public static Team Create(string fullName, string shortName,
            int apiId, string shirtUrl, Arena arena)
        {
            return new Team
            {
              
               Name=fullName,
               ShortName = shortName,
               DbId = apiId,
               ShirtUrl = shirtUrl,
               Arena = arena
            };
        }
        
    }
}