using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Business.Team.Queries;
using FootballLiveCheck.Business.Team.QueryHandlers;
using FootballLiveCheck.Business.Team.QueryResults;
using FootballLiveCheck.Domain.Repositories;
using FootballLiveCheck.Tests.Shared;
using FootballLiveCheck.Tests.Shared.Extensions;
using FootballLiveCheck.Tests.Shared.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballLiveCheck.Business.Tests.Team.Queries
{
    [TestClass]
    public class GetAllTeamsQueryHandlerTest : BaseQueryHandlerTest<GetAllTeamsQueryHandler, GetAllTeamsQuery, GetAllTeamsQueryResult, ITeamRepository>
    {
        private readonly Guid leagueId = new Guid("555F951D-C321-4ED2-8ADA-F0DEAB53C557");

        [TestMethod]
        public void Given_Retrieve_When_PassedNullQuery_Then_Should_ThrowException()
        {
            Action act = () => SystemUnderTest.Retrieve(null);

            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_Retrieve_When_PassedValidQuery_Then_Should_ReturnAllTeams()
        {
            var teams = TeamFactory.GetEntity("Steaua", leagueId, 20).ToQueryableCollection();
            RepositoryMock.Setup(r => r.GetAll()).Returns(teams);
            var models = TeamFactory.GetModel(teams.First()).ToReadOnlyCollection();
            MapperMock.Setup(m => m.Map<IReadOnlyCollection<TeamModel>>(teams)).Returns(models);

            var result =  ExecuteQuery();

            result.Should().NotBeNull();
            result.Teams.Should().NotBeNull();
        }

        protected override GetAllTeamsQueryHandler CreateSystemUnderTest()
        {
            return new GetAllTeamsQueryHandler(MapperMock.Object, RepositoryMock.Object);
        }

        protected override GetAllTeamsQuery CreateQuery()
        {
            return new GetAllTeamsQuery();
        }
    }
}