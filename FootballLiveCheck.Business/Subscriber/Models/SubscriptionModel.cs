
using FootballLiveCheck.Business.Match.Models;

namespace FootballLiveCheck.Business.Subscriber.Models
{
    public class SubscriptionModel
    {
        public string PhoneNumber { get; set; }
        public MatchModel SubcribedGame { get; set; }
    }
}
