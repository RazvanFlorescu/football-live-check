namespace FootballLiveCheck.CqrsCore.Events
{
    public interface IEventHandler<T>
        where T : class, IEvent
    {
        void Handle(T raisedEvent);
    }
}
