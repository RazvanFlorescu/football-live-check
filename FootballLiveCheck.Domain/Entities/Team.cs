using System;

namespace FootballLiveCheck.Domain.Entities
{
    public class Team : BaseEntity
    {
        private Team()
        {
        }

        public string Name { get; private set; }

        public Guid LeagueId { get; private set; }

        public int Points { get; private set; }

        public static Team Create(string name, Guid leagueId, int points)
        {
            return new Team
            {
                Name = name,
                LeagueId = leagueId,
                Points = points
            };
        }
        
    }
}