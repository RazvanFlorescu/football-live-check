using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.League.Queries;
using FootballLiveCheck.Business.League.QueryHandlers;
using FootballLiveCheck.Business.League.QueryResults;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;
using FootballLiveCheck.Tests.Shared;
using FootballLiveCheck.Tests.Shared.Extensions;
using FootballLiveCheck.Tests.Shared.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballLiveCheck.Business.Tests.League.Queries
{
    [TestClass]
    public class GetAllLeaguesQueryHandlerTest : BaseQueryHandlerTest<GetAllLeaguesQueryHandler, GetAllLeaguesQuery,
        GetAllLeaguesQueryResult, ILeagueRepository>
    {
        [TestMethod]
        public void Given_Retrieve_When_PassedNullQuery_Then_Should_ThrowException()
        {
            Action act = () => SystemUnderTest.Retrieve(null);

            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_Retrieve_When_PassedValidQuery_Then_Should_ReturnAllLeagues()
        {
            var region =Region.Create( "regiontest","www.test.ro");
            var leagues = LeagueFactory.GetEntity(20, "LSTN", "LeagueFullTestName",
                "https://www.flagTest.png", region).ToQueryableCollection();
            RepositoryMock.Setup(r => r.GetAll()).Returns(leagues);
            var models = LeagueFactory.GetModel(leagues.First()).ToReadOnlyCollection();
            MapperMock.Setup(m => m.Map<IReadOnlyCollection<LeagueModel>>(leagues)).Returns(models);

            var result = ExecuteQuery();

            result.Should().NotBeNull();
            result.Leagues.Should().NotBeNull();
        }

        protected override GetAllLeaguesQueryHandler CreateSystemUnderTest()
        {
            return new GetAllLeaguesQueryHandler(MapperMock.Object, RepositoryMock.Object);
        }

        protected override GetAllLeaguesQuery CreateQuery()
        {
            return new GetAllLeaguesQuery();
        }
    }
}