using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.CqrsCore.DependencyInjection;
using FootballLiveCheck.CqrsCore.Dispatchers;

namespace FootballLiveCheck.Infrastructure.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IDependencyScope scope;

        public CommandDispatcher(IDependencyScope scope)
        {
            this.scope = scope;
        }


        public void Handle<TCommand>(TCommand command)
            where TCommand : class, ICommand
        {
            var commandHandler = scope.Resolve<ICommandHandler<TCommand>>();
            commandHandler.Handle(command);
        }
    }
}
