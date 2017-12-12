using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FootballLiveCheck.Tests.Shared
{
    public abstract class BaseTest<T>
        where T : class
    {

        protected MockRepository MockRepository { get; private set; }

        protected T SystemUnderTest { get; private set; }

        [TestInitialize]
        public virtual void TestInitialize()
        {
            MockRepository = new MockRepository(MockBehavior.Loose);
            InitializeTestVariables();
            SetupMockings();
            SystemUnderTest = CreateSystemUnderTest();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            MockRepository.VerifyAll();
        }

        protected abstract void SetupMockings();

        protected abstract T CreateSystemUnderTest();

        protected virtual void InitializeTestVariables()
        {
        }
    }
}