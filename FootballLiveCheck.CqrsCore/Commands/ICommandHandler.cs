namespace FootballLiveCheck.CqrsCore.Commands
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
