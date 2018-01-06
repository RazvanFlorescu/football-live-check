using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Business.Team.QueryHandlers;
using FootballLiveCheck.Business.Team.QueryResults;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;
using FootballLiveCheck.Tests.Shared;
using FootballLiveCheck.Tests.Shared.Extensions;
using FootballLiveCheck.Tests.Shared.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballLiveCheck.Business.Tests.Team.Queries
{
    [TestClass]
    public class GetTeamsByLeagueIdQueryHandlerTest : BaseQueryHandlerTest<GetTeamsByLeagueIdQueryHandler, GetTeamsByLeagueIdQuery,
        GetTeamsByLeagueIdQueryResult, ITeamRepository>
    {
        private readonly Guid id = new Guid("7FE4DD91-5D76-4E36-BB09-8AF33C1E5C24");
        private readonly int leagueId = 1241;

        [TestMethod]
        public void Given_Retrieve_When_PassedNullQuery_Then_Should_ThrowException()
        {
            Action act = () => SystemUnderTest.Retrieve(null);

            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_Retrieve_When_PassedValidQuery_Then_Should_ReturnTeamById()
        {
            Arena arena = Arena.Create(1, "arena", 121);
            var teams = TeamFactory.GetEntity("TeamTestName", "ShortName",
                20, "url",arena).ToQueryableCollection();
            RepositoryMock.Setup(r => r.GetTeamsByLeagueId(leagueId)).Returns(teams);
            var models = TeamFactory.GetModel(teams.First()).ToReadOnlyCollection();
            MapperMock.Setup(m => m.Map<IReadOnlyCollection<TeamModel>>(teams)).Returns(models);

            var result = ExecuteQuery();

            result.Should().NotBeNull();
            result.Teams.Should().NotBeNull();
        }

        protected override GetTeamsByLeagueIdQueryHandler CreateSystemUnderTest()
        {
            return new GetTeamsByLeagueIdQueryHandler(MapperMock.Object, RepositoryMock.Object);
        }

        protected override GetTeamsByLeagueIdQuery CreateQuery()
        {
            return new GetTeamsByLeagueIdQuery(leagueId);
        }
    }
}