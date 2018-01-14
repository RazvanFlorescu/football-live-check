

using FootballLiveCheck.Business.Match.Models;
using FootballLiveCheck.Business.Subscriber.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Subscriber.Queries
{
    public class GetSubscriptionQuery : IQuery
    {
        public SubscriptionModel Subscription { get; set; } 

        public GetSubscriptionQuery(SubscriptionModel sub)
        {
            Subscription = sub;
        }
    }
}
