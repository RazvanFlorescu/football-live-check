using AutoMapper;
using FootballLiveCheck.CqrsCore.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FootballLiveCheck.Tests.Shared
{
    public abstract class BaseQueryHandlerTest<TQueryHandler, TQuery, TResult, TRepository> : BaseTest<TQueryHandler>
        where TQuery : class, IQuery
        where TResult : class, IQueryResult
        where TQueryHandler : class, IQueryHandler<TQuery, TResult>
        where TRepository : class
    {
        protected Mock<IMapper> MapperMock { get; private set; }

        protected Mock<TRepository> RepositoryMock { get; private set; }

        protected TQuery Query { get; set; }

        protected abstract TQuery CreateQuery();

        protected override void SetupMockings()
        {
            MapperMock = MockRepository.Create<IMapper>();
            RepositoryMock = MockRepository.Create<TRepository>();
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            Query = CreateQuery();
        }

        protected TResult ExecuteQuery()
        {
            return SystemUnderTest.Retrieve(Query);
        }
    }
}
