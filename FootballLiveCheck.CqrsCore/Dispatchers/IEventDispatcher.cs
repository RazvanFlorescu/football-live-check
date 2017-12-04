using FootballLiveCheck.CqrsCore.Events;

namespace FootballLiveCheck.CqrsCore.Dispatchers
{
    public interface IEventDispatcher
    {
        void Dispatch<TEvent>(TEvent eventToDispatch)
            where TEvent : class, IEvent;
    }
}
