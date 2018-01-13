using EnsureThat;
using FootballLiveCheck.Business.Subscriber.Models;
using FootballLiveCheck.CqrsCore.Commands;

namespace FootballLiveCheck.Business.Subscriber.Commands
{
    public class CreateSubscriptionCommand : ICommand
    {
        public CreateSubscriptionCommand(SubscriptionModel subscription)
        {
            EnsureArg.IsNotNull(subscription);
            SubscriptionModel = subscription;
        }

        public SubscriptionModel SubscriptionModel { get; }
    }
}
