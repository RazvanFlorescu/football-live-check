using FootballLiveCheck.Domain;

namespace FootballLiveCheck.Business.Models.JSONObjects.JLeagues
{
    public class JRegion : BaseJsonObject
    {
       
        public string Name { get; set; }

        public string FlagUrl { get; set; }
    }
}