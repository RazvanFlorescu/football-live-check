using System;
using FootballLiveCheck.Domain;

namespace FootballLiveCheck.Business.Models.JSONObjects.JLeagues
{
    public class JLeague : BaseJsonObject
    {
      
        public string Name { get; set; }

        public string FlagUrl { get; set; }

        public string ShortName { get; set; }

        public JRegion Region { get; set; }
    }
}