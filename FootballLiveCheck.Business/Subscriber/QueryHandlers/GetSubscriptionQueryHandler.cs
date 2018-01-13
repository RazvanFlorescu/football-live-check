

using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Subscriber.Models;
using FootballLiveCheck.Business.Subscriber.Queries;
using FootballLiveCheck.Business.Subscriber.QueryResults;
using FootballLiveCheck.CqrsCore.Queries;
using FootballLiveCheck.Domain.Repositories;
using System.Linq;

namespace FootballLiveCheck.Business.Subscriber.QueryHandlers
{
    public class GetSubscriptionQueryHandler : DatabaseHandler, IQueryHandler<GetSubscriptionQuery, GetSubscriptionQueryResult>
    {
        private readonly ISubscriberRepository SubscriptionsRepo;

        public GetSubscriptionQueryHandler(IMapper mapper, ISubscriberRepository subsRepo) : base(mapper)
        {
            EnsureArg.IsNotNull(subsRepo);
            this.SubscriptionsRepo = subsRepo;
        }

        public GetSubscriptionQueryResult Retrieve(GetSubscriptionQuery query)
        {
            EnsureArg.IsNotNull(query);

            var subscriptionsBySamePhoneNumber = SubscriptionsRepo.Search(s => s.PhoneNumber == query.Subscription.PhoneNumber);
            var matches = Mapper.Map<IQueryable<SubscriptionModel>>(subscriptionsBySamePhoneNumber);
            matches.Where(s => s.SubcribedGame == query.Subscription.SubcribedGame);

            return new GetSubscriptionQueryResult(matches);
        }
    }
}
