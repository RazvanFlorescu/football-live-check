using FootballLiveCheck.CqrsCore.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FootballLiveCheck.Tests.Shared
{
    public abstract class BaseEventHandlerTest<TEventHandler, TEvent, TRepository> : BaseTest<TEventHandler>
        where TEvent : class, IEvent where TEventHandler : class, IEventHandler<TEvent> where TRepository : class
    {

        protected TEvent Event { get; private set; }

        protected Mock<TRepository> RepositoryMock { get; private set; }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            Event = CreateEvent();
        }

        protected abstract TEvent CreateEvent();

        protected void ExecuteEvent()
        {
            SystemUnderTest.Handle(Event);
        }

        protected override void SetupMockings()
        {
            RepositoryMock = MockRepository.Create<TRepository>();
        }
    }
}