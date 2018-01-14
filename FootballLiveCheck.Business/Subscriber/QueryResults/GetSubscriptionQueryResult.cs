
using EnsureThat;
using FootballLiveCheck.Business.Subscriber.Models;
using FootballLiveCheck.CqrsCore.Queries;
using System.Collections.Generic;
using System.Linq;

namespace FootballLiveCheck.Business.Subscriber.QueryResults
{
    public class GetSubscriptionQueryResult : IQueryResult
    {
        public GetSubscriptionQueryResult(IEnumerable<SubscriptionModel> subscriptions)
        {
            EnsureArg.IsNotNull(subscriptions);
            Subscriptions = subscriptions;
        }

        public IEnumerable<SubscriptionModel> Subscriptions { get; }
    }
}
