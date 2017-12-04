using FootballLiveCheck.CqrsCore.DependencyInjection;
using FootballLiveCheck.CqrsCore.Dispatchers;
using FootballLiveCheck.CqrsCore.Events;

namespace FootballLiveCheck.Infrastructure.Dispatchers
{
    public class EventDispatcher : IEventDispatcher
    {
        private readonly IDependencyScope scope;

        public EventDispatcher(IDependencyScope scope)
        {
            this.scope = scope;
        }

        public void Dispatch<TEvent>(TEvent eventToDispatch)
            where TEvent : class, IEvent
        {
            var domainHandler = scope.Resolve<IEventHandler<TEvent>>();
            domainHandler.Handle(eventToDispatch);
        }
    }
}
