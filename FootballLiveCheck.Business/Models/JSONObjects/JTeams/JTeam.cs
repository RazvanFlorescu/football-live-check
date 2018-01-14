using System.Collections.Generic;
using FootballLiveCheck.Business.Models.JSONObjects.JMatches;
using FootballLiveCheck.Domain;

namespace FootballLiveCheck.Business.Models.JSONObjects.JTeams
{
    public class JTeam : BaseJsonObject
    {
        public string Name { get; set; }

        public bool IsNational { get; set; }

        public string ShirtUrl { get; set; }

        public string ShortName { get; set; }

        public string ShortCode { get; set; }

        public JArena Arena { get; set; }

        public ICollection<JMatch> Matches { get; set; }
    }
}