using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FootballLiveCheck.Business.Team.Models;
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
    public class GetTeamByIdQueryHandlerTest : BaseQueryHandlerTest<GetTeamByIdQueryHandler, GetTeamByIdQuery,
        GetTeamByIdQueryResult, ITeamRepository>
    {
        private readonly Guid id = new Guid("7FE4DD91-5D76-4E36-BB09-8AF33C1E5C24");
        private readonly Guid leagueId = new Guid("555F951D-C321-4ED2-8ADA-F0DEAB53C557");

        [TestMethod]
        public void Given_Retrieve_When_PassedNullQuery_Then_Should_ThrowException()
        {
            Action act = () => SystemUnderTest.Retrieve(null);

            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_Retrieve_When_PassedValidQuery_Then_Should_ReturnTeamById()
        {
            var team = TeamFactory.GetEntity("TeamTestName", "ShortName",
                20, "url", 12, 1111, "Ghencea");
            RepositoryMock.Setup(r => r.GetById(id)).Returns(team);
            var model = TeamFactory.GetModel(team);
            MapperMock.Setup(m => m.Map<TeamModel>(team)).Returns(model);

            var result = ExecuteQuery();

            result.Should().NotBeNull();
            result.Team.Should().NotBeNull();
        }

        protected override GetTeamByIdQueryHandler CreateSystemUnderTest()
        {
            return new GetTeamByIdQueryHandler(MapperMock.Object, RepositoryMock.Object);
        }

        protected override GetTeamByIdQuery CreateQuery()
        {
            return new GetTeamByIdQuery(id);
        }
    }
}