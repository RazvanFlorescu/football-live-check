using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Match.Models;
using FootballLiveCheck.Business.Subscriber.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;
using System.Linq;

namespace FootballLiveCheck.Business.Subscriber.CommandHandlers
{
    public class CreationSubscriptionCommandHandler : DatabaseHandler, ICommandHandler<CreateSubscriptionCommand>
    {
        private readonly ISubscriberRepository SubscriptionRepository;

        public CreationSubscriptionCommandHandler(IMapper mapper, ISubscriberRepository subscribeRepo) : base(mapper)
        {
            EnsureArg.IsNotNull(subscribeRepo);
            this.SubscriptionRepository = subscribeRepo;
        }
        public void Handle(CreateSubscriptionCommand command)
        {
            EnsureArg.IsNotNull(command);
            var commandEntity = Mapper.Map<Domain.Entities.Subscriber>(command.SubscriptionModel);
            SubscriptionRepository.Add(commandEntity);
            SubscriptionRepository.SaveChanges();
        }
    }
}
