using FootballLiveCheck.CqrsCore.Commands;

namespace FootballLiveCheck.CqrsCore.Dispatchers
{
    public interface ICommandDispatcher
    {
        
        void Handle<TCommand>(TCommand command)
            where TCommand : class, ICommand;
    }
}
