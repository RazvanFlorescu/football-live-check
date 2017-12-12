using AutoMapper;
using FootballLiveCheck.CqrsCore.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FootballLiveCheck.Tests.Shared
{
    public abstract class BaseCommandHandlerTest<TCommandHandler, TCommand, TRepository> : BaseTest<TCommandHandler>
        where TCommand : class, ICommand
        where TCommandHandler : class, ICommandHandler<TCommand>
        where TRepository : class
    {
        protected Mock<IMapper> MapperMock { get; private set; }

        protected Mock<TRepository> RepositoryMock { get; private set; }

        protected TCommand Command { get; private set; }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            Command = CreateCommand();
        }

        protected abstract TCommand CreateCommand();

        protected override void SetupMockings()
        {
            MapperMock = MockRepository.Create<IMapper>();
            RepositoryMock = MockRepository.Create<TRepository>();
        }

        protected void ExecuteCommand()
        {
            SystemUnderTest.Handle(Command);
        }
    }
}